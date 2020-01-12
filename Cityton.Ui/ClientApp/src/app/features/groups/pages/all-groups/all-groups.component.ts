import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';

import { GroupService } from '@core/services/group.service';

import { IGroupList as GroupList } from '@shared/models/GroupList';

@Component({
  selector: 'app-all-groups',
  templateUrl: './all-groups.component.html',
  styleUrls: ['./all-groups.component.scss']
})
export class AllGroupsComponent implements OnInit {

  // groups$: Observable<Group[]>
  groupList$: Observable<GroupList>;

  constructor(private groupService: GroupService) {
  }

  ngOnInit() {
    console.log("LOLOLOLOL");
    this.groupList$ = this.groupService.getAll();
    console.log("AZAZAZZAZAZ");
  }

  sendRequest(groupId: string) {
      this.groupService.membershipRequest(groupId).subscribe();
  }



}
