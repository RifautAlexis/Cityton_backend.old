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

  private currentToken: BehaviorSubject<string>;

  constructor(private http: HttpClient) {
    const data = JSON.parse(localStorage.getItem('currentToken'));

    this.currentToken = new BehaviorSubject<string>(data ? data : null);
  }

  updateCurrentToken(token: string) {
    this.currentToken.next(token);
  }

  currentTokenValue() {
    return localStorage.getItem('currentToken');
  }

  login(email: string, password: string): Observable<string> {
    return this.http.post<string>(environment.apiUrl + 'authenticate/login', { email, password })
      .pipe(map((data: any) => {

        let token = JSON.stringify(data.token);

        if (token) {
          localStorage.setItem('currentToken', token);
          this.currentToken.next(token);
        }

        return token;
      })

      )
  }

  register(userRegister: UserRegister): Observable<string> {
    return this.http.post<string>(environment.apiUrl + 'authenticate/register', userRegister)
      .pipe(map((token: string) => {

        if (token) {
          localStorage.setItem('currentToken', JSON.stringify(token));
          this.currentToken.next(token);
        }

        return token;
      })

      )
  }

  logout() {
    localStorage.removeItem('currentToken');
    this.currentToken.next(null);
  }

  getConnectedUser(): Observable<User> {
    return this.http.get<User>(environment.apiUrl + 'authenticate');
  }

}
