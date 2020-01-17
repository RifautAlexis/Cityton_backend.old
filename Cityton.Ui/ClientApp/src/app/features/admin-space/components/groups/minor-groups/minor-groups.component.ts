import { Component, OnInit, Input } from '@angular/core';

import { IGroup as Group } from '@shared/models/Group';

@Component({
  selector: 'app-minor-groups',
  templateUrl: './minor-groups.component.html',
  styleUrls: ['./minor-groups.component.scss']
})
export class MinorGroupsComponent implements OnInit {

  @Input() minorGroups: Group[];

  constructor() { }

  ngOnInit() {
  }

}
