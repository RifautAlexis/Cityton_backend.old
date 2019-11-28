import { environment } from './../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

import { IUser as User } from '@shared/models/User';
import { Role } from '@shared/models/Enum';

import { Observable, BehaviorSubject } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) {
  }

  update(userToUpdate: User, password: string = ""): Observable<User> {

    return this.http.put<User>(environment.apiUrl + 'user/update/' + userToUpdate.id, { userToUpdate, password })
      .pipe(map((user: User) => {

        if (user) {
          return user;
        }

        return null;
      })

      )
  }

  searchUser(username: string, securityLevel: string):Observable<User[]> {

    let params = new HttpParams()
                  .set('q', username) //q => query
                  .set('sl', securityLevel); //sl => securityLevel

    return this.http.get<User[]>(environment.apiUrl + 'user/searchUser', { params });
  }

}
