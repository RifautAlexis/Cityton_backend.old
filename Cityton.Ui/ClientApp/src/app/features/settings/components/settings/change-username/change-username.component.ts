import { Component, OnInit, Input } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';
import { IUserToUpdate as UserToUpdate } from '@shared/models/UserToUpdate';
import { ExistUsernameValidator } from '@shared/form-validators/user';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-change-username',
  templateUrl: './change-username.component.html',
  styleUrls: ['./change-username.component.scss']
})
export class ChangeUsernameComponent implements OnInit {

  @Input() connectedUser$: Observable<User>;
  connectedUser: User;

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

    this.connectedUser$.subscribe(
      (user: User) => {
        this.connectedUser = user;
      }
    );
  }

  onSubmit() {
    if (this.usernameForm.invalid) {
      return;
    }

    let user: UserToUpdate = {
      id: this.connectedUser.id,
      username: this.usernameForm.controls.username.value,
      phoneNumber: this.connectedUser.phoneNumber,
      email: this.connectedUser.email,
      picture: this.connectedUser.picture,
      role: this.connectedUser.role,
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

  cancel(formToReset: FormGroup) {
    formToReset.reset();
  }

}
