import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';

@Component({
  selector: 'app-change-username',
  templateUrl: './change-username.component.html'
})
export class ChangeUsernameComponent implements OnInit {

  usernameForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private userService: UserService, private authService: AuthService) { }

  ngOnInit() {
    this.usernameForm = this.formBuilder.group({
      username: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.usernameForm.invalid) {
      return;
    }

    let currentUser: User = this.authService.currentUserValue();

    let user: User = {
      id: currentUser.id,
      username: this.usernameForm.controls.username.value,
      phoneNumber: currentUser.phoneNumber,
      email: currentUser.email,
      picture: currentUser.picture,
      role: currentUser.role,
      token: this.authService.currentTokenValue()
    };

    this.userService.update(user).subscribe(
      (data: User) => {
        // this.router.navigate(['chat']);
      },
      (error: any) => {
        console.log(error);
      }
    );
  }

  cancel(formToReset: NgForm) {
    formToReset.reset();
  }

}
