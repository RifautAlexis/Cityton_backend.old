import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';

import { ExistPhoneNumberValidator } from '@shared/form-validators/user';

@Component({
  selector: 'app-change-phoneNumber',
  templateUrl: './change-phoneNumber.component.html',
  styleUrls: ['./change-phoneNumber.component.scss']
})

export class ChangePhoneNumberComponent implements OnInit {

  phoneNumberForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private userService: UserService,
    private authService: AuthService,
    private existPhoneNumberValidator: ExistPhoneNumberValidator) { }

  ngOnInit() {
    this.phoneNumberForm = this.formBuilder.group({
      phoneNumber: ['',
        {
          validators: [
            Validators.required,
            Validators.minLength(10)
          ],
          asyncValidators: [this.existPhoneNumberValidator.validate]
        }
      ]
    });
  }

  onSubmit() {
    if (this.phoneNumberForm.invalid) {
      return;
    }

    let currentUser: User = this.authService.currentUserValue();

    let user: UserToUpdate = {
      id: currentUser.id,
      username: currentUser.username,
      phoneNumber: this.phoneNumberForm.controls.username.value,
      email: currentUser.email,
      picture: currentUser.picture,
      role: currentUser.role,
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
