import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';

import { UserService } from '@core/services/user.service';

import { IUser as User } from '@shared/models/User';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-search-user',
  templateUrl: './search-user.component.html'
})

export class SearchUserComponent implements OnInit {

  searchForm: FormGroup;
  selectedSecurity: string = "All";
  users: Observable<User[]>;

  constructor(private formBuilder: FormBuilder, private userService: UserService) {
    console.log(this.users);
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
    console.log(username);
    this.users = this.userService.searchUser(username, this.selectedSecurity);
  }

}
