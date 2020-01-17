import { Observable, of } from 'rxjs';
import { Component, OnInit } from '@angular/core';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.scss']
})
export class GroupsComponent implements OnInit {

  minorGroups$: Observable<Group[]>;
  minorGroups: Group[];

  groups$: Observable<Group[]>;
  searchField: string;

  constructor(
    private groupService: GroupService,
    private router: Router,
    private route: ActivatedRoute) { }

  ngOnInit() {
    this.refreshMinorGroups();

    this.searchField = this.route.snapshot.queryParamMap.get('toSearch');
    if(this.searchField !== "") {
      this.search();
    }
  }

  deleteGroup(groupId: string) {
    this.groupService.deleteGroup(groupId).subscribe();

    if (this.minorGroups.find(g => g.id === Number(groupId))) {
      this.refreshMinorGroups();
    }

  }

  private refreshMinorGroups() {
    this.groupService.getMinorGroups().subscribe(
      (groups: Group[]) => {
        this.minorGroups$ = of(groups);
        this.minorGroups = groups;
      }
    );
  }

  private search() {
    let toSearch: string = this.searchField ? this.searchField : "";

    this.groups$ = this.groupService.searchGroups(toSearch);
  }

}
