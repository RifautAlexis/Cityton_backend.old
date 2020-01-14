import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { IGroupList as GroupList } from '@shared/models/GroupList';
import { IGroupDetails as GroupDetails } from '@shared/models/GroupDetails';
import { IGroup as Group } from '@shared/models/Group';

@Injectable({
  providedIn: 'root'
})
export class GroupService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<GroupList> {
    return this.http.get<GroupList>(environment.apiUrl + 'group');
  }

  get(groupId: string): Observable<GroupDetails> {
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

  leaveGroup(requestId: number) {
    return this.http.delete<any>(environment.apiUrl + 'group/leaveGroup/' + requestId);
  }

  existName(name: string) {
    return this.http.get<boolean>(environment.apiUrl + 'group/existName/' + name);
  }

  create(name: string): Observable<number> {

    let group = {
      name: name,
      createdAt: new Date()
    }

    return this.http.post<number>(environment.apiUrl + 'group/create', group);
  }

}
