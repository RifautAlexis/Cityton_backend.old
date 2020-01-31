import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { IChallengeList as ChallengeList } from '@shared/models/ChallengeList';

@Injectable({
  providedIn: 'root'
})
export class ChallengeService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<ChallengeList> {
    return this.http.get<ChallengeList>(environment.apiUrl + 'challenge');
  }

}