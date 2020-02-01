import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { IChallenge as Challenge } from '@shared/models/Challenge';

@Injectable({
  providedIn: 'root'
})
export class ChallengeService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Challenge[]> {
    return this.http.get<Challenge[]>(environment.apiUrl + 'challenge');
  }

  existName(name: string) {
    return this.http.get<boolean>(environment.apiUrl + 'challenge/existName/' + name);
  }

  create(name: string, statement: string): Observable<number> {

    let newChallenge = {
      name: name,
      statement: statement
    }

    return this.http.post<number>(environment.apiUrl + 'group/createByMember', newChallenge);
  }

}
