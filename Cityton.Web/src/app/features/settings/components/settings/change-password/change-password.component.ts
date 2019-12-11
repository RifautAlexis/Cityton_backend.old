import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';

@Component({
  selector: 'app-change-password',
  templateUrl: './change-password.component.html'
})
export class ChangePasswordComponent implements OnInit {

  passwordForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private userService: UserService, private authService: AuthService) { }

  ngOnInit() {
    this.passwordForm = this.formBuilder.group({
      password: ['', Validators.required],
      confirmPassword:  ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.passwordForm.invalid) {
      return;
    }

    let currentUser: User = this.authService.currentUserValue();

    let user: UserToUpdate = {
      id: currentUser.id,
      username: currentUser.username,
      phoneNumber: currentUser.phoneNumber,
      email: currentUser.email,
      picture: currentUser.picture,
      role: currentUser.role,
      token: this.authService.currentTokenValue(),
      password: ""
    };

    this.userService.update(user).subscribe(
      (user: User) => {
        this.authService.updateCurrentUser(user);

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
