import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup } from '@angular/forms';

import { UserService } from '@core/services/user.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';
import { Role } from '@shared/models/Enum';
import { MatDialog } from '@angular/material';
import { EditUserComponent } from '../edit-user/edit-user.component';

import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-search-user',
  templateUrl: './search-user.component.html'
})

export class SearchUserComponent implements OnInit {

  searchForm: FormGroup;
  selectedSecurity: string = "All";
  users$: Observable<User[]>;
  users: User[];
  Role = Role;

  constructor(
    private formBuilder: FormBuilder,
    private userService: UserService,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.searchForm = this.formBuilder.group({
      search: ['']
    });
  }

  onChange(security: string) {
    this.selectedSecurity = security;
  }

  onSubmit() {
    if (this.searchForm.invalid) {
      return;
    }

    let username: string = this.searchForm.controls.search.value ? this.searchForm.controls.search.value : "";

    this.users$ = this.userService.searchUser(username, this.selectedSecurity)
      .pipe(map((users: User[]) => {
        this.users = users;
        return users;
      }));
  }

  changeSecurityLevel(id: string, newSecurityLevel: string) {

    let user: User = this.users.find(user => user.id.toString() == id);
    user.role = Role[newSecurityLevel];

    let userToUpdate: UserToUpdate = {
      id: user.id,
      username: user.username,
      phoneNumber: user.phoneNumber,
      email: user.email,
      picture: user.picture,
      role: user.role,
      password: ""
    };

    this.userService.update(userToUpdate);
  }

  DeleteUser(userId: string) {
    this.userService.deleteUser(userId);
  }

  async openDialog(userId: string) {
    let user: User = null;

    await this.userService.get(userId).then(
      (data: User) => {

        user = data;
      },
      err => console.log(err)
    );

    const dialogRef = this.dialog.open(EditUserComponent, {
      width: '250px',
      data: user
    });

    dialogRef.afterClosed().subscribe((data: UserToUpdate) => {
      if (data) this.userService.update(data);
    });
  }

}
