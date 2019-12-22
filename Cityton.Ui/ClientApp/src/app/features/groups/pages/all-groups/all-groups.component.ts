import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-all-groups',
  templateUrl: './all-groups.component.html',
  styleUrls: ['./all-groups.component.scss']
})
export class AllGroupsComponent implements OnInit {

  groups$: Observable<Group[]>

  constructor(private groupService: GroupService) { }

  ngOnInit() {
    this.groups$ = this.groupService.getAll();
  }

  sendRequest(groupId : string) {
    this.groupService.membershipRequest(groupId);
  }

}
