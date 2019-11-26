import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

import { AuthService } from '@core/services/auth.service';

import { IUserRegister as UserRegister } from '@shared/models/UserRegister';
import { IUser as User } from '@shared/models/User';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})

export class RegisterComponent implements OnInit {

  registerForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router, private authService: AuthService) { }

  ngOnInit() {

    this.registerForm = this.formBuilder.group({
      username: ['', Validators.required],
      phoneNumber: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required]
    });

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
          this.router.navigate(['settings']);
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
