import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { IGroup as Group } from '@shared/models/Group';

@Component({
  selector: 'app-minor-groups',
  templateUrl: './minor-groups.component.html',
  styleUrls: ['./minor-groups.component.scss']
})
export class MinorGroupsComponent implements OnInit {

  @Output() parentDeleteGroup: EventEmitter<number> = new EventEmitter();

  @Input() minorGroups: Group[];

  constructor() { }

  ngOnInit() {
  }

  deleteGroup(groupId: string) {
    this.parentDeleteGroup.emit(Number(groupId));
  }

}
