import { Component, OnInit, Inject, EventEmitter, Output } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatListOption } from '@angular/material';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';

import { UserService } from '@core/services/user.service';
import { CompanyService } from '@core/services/company.service';

import { IUserMinimal as UserMinimal } from '@shared/models/UserMinimal';
import { ICompany as Company } from '@shared/models/Company';
import { IGroupToEdit as GroupToEdit } from '@shared/models/GroupToEdit';

import { Observable, forkJoin, BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-edit-groups',
  templateUrl: './edit-groups.component.html',
  styleUrls: ['./edit-groups.component.scss']
})
export class EditGroupsComponent implements OnInit {

  name: string;
  selectedUsers: UserMinimal[];
  selectedCreator: UserMinimal[];

  resultSRequests$: Observable<[UserMinimal[], Company]>;

  // usersSelected: UserMinimal[] = [];
  // creatorSelected: UserMinimal;

  usersWithoutGroup: UserMinimal[];

  constructor(
    public dialogRef: MatDialogRef<EditGroupsComponent>,
    private userService: UserService,
    private companyService: CompanyService,
    @Inject(MAT_DIALOG_DATA) public data: GroupToEdit
  ) { }

  ngOnInit() {
    this.resultSRequests$ = forkJoin(this.userService.getUsersWithoutGroup(), this.companyService.getSettings());

    this.resultSRequests$.subscribe(
      (data: [UserMinimal[], Company]) => {
        this.selectedCreator = [this.data.creator];
        this.selectedUsers = [this.data.creator, ...this.data.members];
        [...this.selectedUsers].sort((current, next) => this.compare(current, next));

        this.usersWithoutGroup = [...this.selectedUsers, ...data[0]];

        this.name = this.data.name;

      }
    );

  }

  compare(obj01: UserMinimal, obj02: UserMinimal) {
    return obj01.username.localeCompare(obj02.username, 'en', {sensitivity: 'base'})
  }

  selectMembers(choices: MatListOption[]) {

    this.selectedUsers = choices.map(choice => choice.value);

    if ((this.selectedCreator[0] !== null && this.selectedCreator[0] !== undefined) && !this.selectedUsers.some(user => user.id == this.selectedCreator[0].id)) {
      this.selectedCreator[0] = null;
    }

  }

  selectCreator(choices: MatListOption[]) {

    if (choices[0] === undefined) {
      this.selectedCreator[0] = null;
    } else {
      this.selectedCreator[0] = choices[0].value;
    }

  }

  usersSelectedContains(userId: number) {
    return this.selectedUsers.some(user => user.id === userId)
  }

  isGroupValidate(minGroupSize: number, maxGroupSize: number): boolean {
    return (this.name !== undefined && this.name.length >= 3 &&
      this.selectedUsers.length >= minGroupSize && this.selectedUsers.length <= maxGroupSize &&
      this.selectedCreator[0] != undefined && this.selectedCreator[0] != null);
  }

  CompareUsers(user01: UserMinimal, user02: UserMinimal) {
    console.log(user01, user02, (user01.id === user02.id && user01.username === user02.username));
    return user01.id === user02.id && user01.username === user02.username;
  }

  // ***************************************** //

  submit() {
    this.dialogRef.close({
      name: this.name,
      creator: this.selectedCreator[0],
      members: this.selectedUsers.filter(user => user.id != this.selectedCreator[0].id)
    });
  }

  cancel() {
    this.dialogRef.close();
  }

}
