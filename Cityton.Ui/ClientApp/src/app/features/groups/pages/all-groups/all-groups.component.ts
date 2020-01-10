import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';
import { group } from '@angular/animations';

@Component({
  selector: 'app-all-groups',
  templateUrl: './all-groups.component.html',
  styleUrls: ['./all-groups.component.scss']
})
export class AllGroupsComponent implements OnInit {

  // groups$: Observable<Group[]>
  groups: Group[];

  constructor(private groupService: GroupService) {
  }

  ngOnInit() {
    this.groupService.getAll().subscribe(
      (groups: Group[]) => {
        this.groups = groups;
        console.log(groups);
      }
    );
  }

  sendRequest(groupId: string) {
    if(this.groups.findIndex(group => group.id === Number(groupId) && !group.hasRequested))
      this.groupService.membershipRequest(groupId).subscribe();
  }



}
