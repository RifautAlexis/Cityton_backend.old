import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

import { AuthService } from '@core/services/auth.service';

import { IUserRegister as UserRegister } from '@shared/models/UserRegister';
import { IUser as User } from '@shared/models/User';

import { UniqueUsernameValidator,
  UniquePhoneNumberValidator,
  UniqueEmailValidator,
  equalPasswordsValidator } from '@shared/form-validators/user';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})

export class RegisterComponent implements OnInit {

  registerForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
    private router: Router,
    private authService: AuthService,
    private uniqueUsernameValidator: UniqueUsernameValidator,
    private uniquePhoneNumberValidator: UniquePhoneNumberValidator,
    private uniqueEmailValidator: UniqueEmailValidator) { }

  ngOnInit() {

    this.registerForm = this.formBuilder.group({
      username: ['',
        {
          validators: [
            Validators.required,
            Validators.minLength(3)
          ],
          asyncValidators: [this.uniqueUsernameValidator.validate]
        }
      ],
      phoneNumber: ['',
        {
          validators: [
            Validators.required,
            Validators.minLength(10)
          ],
          asyncValidators: [this.uniquePhoneNumberValidator.validate]
        }
      ],
      email: ['',
        {
          validators: [
            Validators.required,
            Validators.email
          ],
          asyncValidators: [this.uniqueEmailValidator.validate]
        }
      ],
      password: ['', [
        Validators.required,
        Validators.minLength(8)
      ]],
      confirmPassword: ['', Validators.required]
    });

    this.registerForm.setValidators(equalPasswordsValidator);

  }

  onSubmit() {

    if (this.registerForm.invalid) {
      return;
    }

    let userRegister: UserRegister = {
      username: this.registerForm.controls.username.value,
      phoneNumber: this.registerForm.controls.phoneNumber.value,
      email: this.registerForm.controls.email.value,
      password: this.registerForm.controls.password.value,
      companyId: 1
    };

    this.authService.register(this.registerForm.value)
      .subscribe(
        (data: User) => {
          this.router.navigate(['chat']);
        },
        (error: any) => {
          console.log(error);
        }
      )

  }

  cancel() {
    this.router.navigate(['']);
  }

}
