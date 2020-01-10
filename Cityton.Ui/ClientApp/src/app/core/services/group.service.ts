import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { IGroup as Group } from '@shared/models/Group';
import { IGroupDetails as GroupDetails } from '@shared/models/GroupDetails';

@Injectable({
  providedIn: 'root'
})
export class GroupService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Group[]> {
    return this.http.get<Group[]>(environment.apiUrl + 'group');
  }

  get(groupId: number): Observable<GroupDetails> {
    return this.http.get<GroupDetails>(environment.apiUrl + 'group/' + groupId);
  }

  membershipRequest(groupId): Observable<any> {
    return this.http.post<any>(environment.apiUrl + 'group/membershipRequest/', groupId);
  }

  acceptRequest(requestId): Observable<any> {
    return this.http.post<any>(environment.apiUrl + 'group/acceptRequest/', requestId);

  }

  declineRequest(requestId): Observable<any> {
    return this.http.delete<any>(environment.apiUrl + 'group/declinRequest/' + requestId);

  }

}
