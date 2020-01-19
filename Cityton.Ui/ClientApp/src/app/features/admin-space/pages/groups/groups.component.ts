import { CreateGroupsComponent } from './../../components/groups/create-groups/create-groups.component';
import { CreateComponent } from './../../../groups/pages/create/create.component';
import { Component, OnInit } from '@angular/core';

import { Router, ActivatedRoute } from '@angular/router';
import { Observable, of } from 'rxjs';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';

import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.scss']
})
export class GroupsComponent implements OnInit {

  minorGroups$: Observable<Group[]>;
  minorGroups: Group[];

  groups$: Observable<Group[]> = of([]);
  searchField: string;

  constructor(
    private groupService: GroupService,
    private router: Router,
    private route: ActivatedRoute,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.refreshMinorGroups();

    this.searchField = this.route.snapshot.queryParamMap.get('toSearch');
    if(this.searchField !== "" && this.searchField !== null && this.searchField.length !== 0 ) {
      this.search();
    }
  }

  deleteGroup(groupId: string) {
    this.groupService.deleteGroup(groupId).subscribe();

    if (this.minorGroups.find(g => g.id === Number(groupId))) {
      this.refreshMinorGroups();
    }

  }

  openCreateGroup(): void {
    const dialogRef = this.dialog.open(CreateGroupsComponent, {
      width: '450px'
    });

    dialogRef.afterClosed().subscribe((result: any) => {
      this.groupService.createByAdmin(result.name, result.creator, result.members).subscribe();
    });
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
