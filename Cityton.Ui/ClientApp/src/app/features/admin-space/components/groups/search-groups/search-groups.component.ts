import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

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
  @Output() toSearch: EventEmitter<string> = new EventEmitter();

  @Input() groups: Group[];
  @Input() searchField: string;

  constructor(
    private groupService: GroupService,
    private router: Router,
    private route: ActivatedRoute) { }

  ngOnInit() {
    console.log(this.searchField);
  }

  onSubmit() {
    // let toSearch: string = this.searchField ? this.searchField : "";
    console.log(this.searchField);
    // this.router.navigate(['admin/groups'], { queryParams: {toSearch: this.searchField} });
    this.toSearch.emit(this.searchField);
  }

  editGroup(groupId: string) {

  }

  deleteGroup(groupId: string) {
    this.parentDeleteGroup.emit(Number(groupId));
  }

}
