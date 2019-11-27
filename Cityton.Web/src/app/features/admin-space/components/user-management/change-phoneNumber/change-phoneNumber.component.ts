import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';

@Component({
  selector: 'app-change-phoneNumber',
  templateUrl: './change-phoneNumber.component.html'
})

export class ChangePhoneNumberComponent implements OnInit {

  phoneNumberForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private userService: UserService, private authService: AuthService) { }

  ngOnInit() {
    this.phoneNumberForm = this.formBuilder.group({
      phoneNumber: ['', Validators.required]
    });
  }

  onSubmit() {
    if (this.phoneNumberForm.invalid) {
      return;
    }

    let currentUser: User = this.authService.currentUserValue();

    let user: User = {
      id: currentUser.id,
      username: currentUser.username,
      phoneNumber: this.phoneNumberForm.controls.username.value,
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
