import { Component, OnInit, EventEmitter, Output } from '@angular/core';

import { Observable } from 'rxjs';
import { Router, ActivatedRoute } from '@angular/router';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';

@Component({
  selector: 'app-search-groups',
  templateUrl: './search-groups.component.html',
  styleUrls: ['./search-groups.component.scss']
})
export class SearchGroupsComponent implements OnInit {

  @Output() parentDeleteGroup: EventEmitter<number> = new EventEmitter();

  groups$: Observable<Group[]>;

  searchField: string;

  constructor(
    private groupService: GroupService,
    private router: Router,
    private route: ActivatedRoute) { }

  ngOnInit() {

    this.searchField = this.route.snapshot.queryParamMap.get('toSearch');

    if(this.searchField !== "") {
      this.search();
    }
  }

  onSubmit() {
    let toSearch: string = this.searchField ? this.searchField : "";

    this.router.navigate(['admin/groups'], { queryParams: {toSearch: toSearch} });
  }

  private search() {
    let toSearch: string = this.searchField ? this.searchField : "";

    this.groups$ = this.groupService.searchGroups(toSearch);
  }

  editGroup(groupId: string) {

  }

  deleteGroup(groupId: string) {
    this.parentDeleteGroup.emit(Number(groupId));
  }

}
