import { AbstractControl, AsyncValidator, ValidationErrors, FormGroup } from '@angular/forms';
import { UserService } from '@core/services/user.service';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

export function equalPasswordsValidator(formGroup: FormGroup): ValidationErrors {
  let password: string = formGroup.controls.password.value;
    let confirmPassword: string = formGroup.controls.confirmPassword.value;

    return password === confirmPassword ? null : { passwordsNotEqual: true };
}

@Injectable({ providedIn: 'root' })
export class UniqueEmailValidator implements AsyncValidator {
  constructor(private userService: UserService) {}

  validate = (ctrl: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
    return this.userService.isUniqueEmail(ctrl.value).pipe(
      map((isEmailTaken: boolean) => {
        console.log(isEmailTaken);
        return (isEmailTaken ? { uniqueEmail: true } : null)
      }),
      catchError(() => null)
    );
  }
}

@Injectable({ providedIn: 'root' })
export class UniquePhoneNumberValidator implements AsyncValidator {
  constructor(private userService: UserService) {}

  validate = (ctrl: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
    return this.userService.isUniquePhoneNumber(ctrl.value).pipe(
      map((isPhoneNumberTaken: boolean) => {
        console.log(isPhoneNumberTaken);
        return (isPhoneNumberTaken ? { uniquePhoneNumber: true } : null)
      }),
      catchError(() => null)
    );
  }
}

@Injectable({ providedIn: 'root' })
export class UniqueUsernameValidator implements AsyncValidator {
  constructor(private userService: UserService) {}

  validate = (ctrl: AbstractControl): Promise<ValidationErrors | null> | Observable<ValidationErrors | null> => {
    return this.userService.isUniqueUsername(ctrl.value).pipe(
      map((isUsernameTaken: boolean) => {
        console.log(isUsernameTaken);
        return (isUsernameTaken ? { uniqueUsername: true } : null)
      }),
      catchError(() => null)
    );
  }
}
