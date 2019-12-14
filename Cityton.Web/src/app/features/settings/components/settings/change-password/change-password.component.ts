import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm, ValidatorFn, ValidationErrors, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';

import { equalPasswordsValidator } from '@shared/form-validators/user';

@Component({
  selector: 'app-change-password',
  templateUrl: './change-password.component.html'
})
export class ChangePasswordComponent implements OnInit {

  passwordForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private userService: UserService,
    private authService: AuthService) {

    this.passwordForm = this.formBuilder.group({
      password: ['', [
        Validators.required,
        Validators.minLength(8)
      ]],
      confirmPassword: ['', Validators.required]
    });

    this.passwordForm.setValidators(equalPasswordsValidator);
   }

  ngOnInit() {  }

  onSubmit() {
    if (this.passwordForm.invalid) {
      return;
    }

    let currentUser: User = this.authService.currentUserValue();
    let password = this.passwordForm.controls.password.value;

    let user: UserToUpdate = {
      id: currentUser.id,
      username: currentUser.username,
      phoneNumber: currentUser.phoneNumber,
      email: currentUser.email,
      picture: currentUser.picture,
      role: currentUser.role,
      token: this.authService.currentTokenValue(),
      password: (password ? password : "")
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

  checkEqualPasswords(formGroup: FormGroup): ValidationErrors {

    let password: string = formGroup.controls.password.value;
    let confirmPassword: string = formGroup.controls.confirmPassword.value;

    console.log(password + " " + confirmPassword);
    console.log(password !== confirmPassword);

    return password === confirmPassword ? null : { passwordsNotEqual: true };
  }

}

// export const passwordsNotEqual: ValidatorFn = (control: FormGroup): ValidationErrors | null => {
//   const password = control.get('password');
//   const confirmPassword = control.get('confirmPassword');

//   console.log("identityRevealedValidator Called")

//   return password && confirmPassword && password.value === confirmPassword.value ? { 'passwordsNotEqual': true } : null;
// };
