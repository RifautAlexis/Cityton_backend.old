import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';
import { ExistUsernameValidator } from '@shared/form-validators/user';

@Component({
  selector: 'app-change-username',
  templateUrl: './change-username.component.html',
  styleUrls: ['./change-username.component.scss']
})
export class ChangeUsernameComponent implements OnInit {

  usernameForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private userService: UserService,
    private authService: AuthService,
    private existUsernameValidator: ExistUsernameValidator) { }

  ngOnInit() {
    this.usernameForm = this.formBuilder.group({
      username: ['',
        {
          validators: [
            Validators.required,
            Validators.minLength(3)
          ],
          asyncValidators: [this.existUsernameValidator.validate]
        }
      ]
    });
  }

  onSubmit() {
    if (this.usernameForm.invalid) {
      return;
    }

    let currentUser: User = this.authService.currentUserValue();
    let obj: User = JSON.parse(this.authService.currentTokenValue());

    let user: UserToUpdate = {
      id: currentUser.id,
      username: this.usernameForm.controls.username.value,
      phoneNumber: currentUser.phoneNumber,
      email: currentUser.email,
      picture: currentUser.picture,
      role: currentUser.role,
      password: ""
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
