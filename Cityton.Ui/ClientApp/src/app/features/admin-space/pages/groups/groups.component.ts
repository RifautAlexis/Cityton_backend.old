import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.scss']
})
export class GroupsComponent implements OnInit {

  minorGroups$: Observable<Group[]>;

  constructor(
    private groupService: GroupService) { }

  ngOnInit() {
    this.minorGroups$ = this.groupService.getMinorGroups();
  }

}
