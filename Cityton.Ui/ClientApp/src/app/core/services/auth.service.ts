import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { IUser as User } from '@shared/models/User';
import { IUserRegister as UserRegister } from '@shared/models/UserRegister';

import { Observable, BehaviorSubject } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private currentUser: BehaviorSubject<User>;

  constructor(private http: HttpClient) {
    const data = JSON.parse(localStorage.getItem('currentUser'));

    this.currentUser = new BehaviorSubject<User>(data ? data : null);
  }

  currentUserValue() {
    return this.currentUser.value;
  }

  updateCurrentUser(user: User) {
    this.currentUser.next(user);
  }

  currentTokenValue() {
    return localStorage.getItem('currentUser');
  }

  login(email: string, password: string): Observable<User> {
    return this.http.post<User>(environment.apiUrl + 'authenticate/login', { email, password })
      .pipe(map((user: User) => {

        if (user) {
          localStorage.setItem('currentUser', JSON.stringify(user.token));
          this.currentUser.next(user);
        }

        return user;
      })

      )
  }

  register(userRegister: UserRegister): Observable<User> {
    return this.http.post<User>(environment.apiUrl + 'authenticate/register', userRegister)
      .pipe(map((user: User) => {

        if (user) {
          localStorage.setItem('currentUser', JSON.stringify(user.token));
          this.currentUser.next(user);
        }

        return user;
      })

      )
  }

  logout() {
    localStorage.removeItem('currentUser');
    this.currentUser.next(null);
  }

}
