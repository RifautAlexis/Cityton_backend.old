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

}
