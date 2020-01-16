import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group'
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-search-groups',
  templateUrl: './search-groups.component.html',
  styleUrls: ['./search-groups.component.scss']
})
export class SearchGroupsComponent implements OnInit {

  groups$: Observable<Group[]>;

  searchField: string;

  constructor(
    private groupService: GroupService) { }

  ngOnInit() {
  }

  onSubmit() {
    let toSearch: string = this.searchField ? this.searchField : "";

    this.groups$ = this.groupService.searchGroups(toSearch);
  }

  editGroup(groupId: string) {

  }

  deleteGroup(groupId: string) {
    this.groupService.deleteGroup(groupId).subscribe();
  }

}
