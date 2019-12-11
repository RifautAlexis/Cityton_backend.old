import { map } from 'rxjs/operators';
import { ImportDatalComponent } from './../../IO-data/import-data/import-data.component';
import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';

import { UserService } from '@core/services/user.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';
import { ISearchUser as SearchUser } from '@shared/models/SearchUser';
import { Role } from '@shared/models/Enum';
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

  constructor(private formBuilder: FormBuilder, private userService: UserService) {
  }

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
      token: user.token,
      password: ""
    };

    this.userService.update(userToUpdate);
  }

}
