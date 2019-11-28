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
  selectedSecurity: string;
  users: Observable<User[]>;

  constructor(private formBuilder: FormBuilder, private userService: UserService) {
  }

  ngOnInit() {
    this.searchForm = this.formBuilder.group({
      search: ['', Validators.required]
    });
  }

  onChange(security: string) {
    this.selectedSecurity = security;
  }

  onSubmit() {
    if (this.searchForm.invalid) {
      return;
    }

    let search: any = {
      username: this.searchForm.controls.search.value
    }

    this.users = this.userService.searchUser(search.username, this.selectedSecurity);
  }

}
