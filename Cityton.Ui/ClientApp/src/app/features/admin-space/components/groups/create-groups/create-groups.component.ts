import { Component, OnInit, Inject, EventEmitter, Output } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatListOption } from '@angular/material';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';

import { UserService } from '@core/services/user.service';
import { CompanyService } from '@core/services/company.service';
import { GroupService } from '@core/services/group.service';

import { IUserMinimal as UserMinimal } from '@shared/models/UserMinimal';
import { ICompany as Company } from '@shared/models/Company';

import { Observable, forkJoin, BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-create-groups',
  templateUrl: './create-groups.component.html',
  styleUrls: ['./create-groups.component.scss']
})
export class CreateGroupsComponent implements OnInit {

  name: string;

  resultSRequests$: Observable<[UserMinimal[], Company]>;

  usersSelected: UserMinimal[] = [];
  creatorSelected: UserMinimal;

  nameError: string;

  constructor(
    public dialogRef: MatDialogRef<CreateGroupsComponent>,
    private userService: UserService,
    private companyService: CompanyService,
    private groupService: GroupService
  ) { }

  ngOnInit() {

    this.resultSRequests$ = forkJoin(this.userService.getUsersWithoutGroup(), this.companyService.getSettings());

  }

  checkError() {
    if (this.name === '') {
      this.nameError = "Is required";

    } else if (this.name.length < 3) {
      this.nameError = "Have to be greater or equals to 3 characters";
    } else {

      this.groupService.existName(this.name).subscribe(
        (nameExist: boolean) => {
          if (nameExist) this.nameError = "This name is already taken";
        }
      )

    }

    console.log(this.name);
    console.log(this.nameError);
  }

  selectMembers(choices: MatListOption[]) {

    this.usersSelected = choices.map(choice => choice.value);

    if ((this.creatorSelected !== null && this.creatorSelected !== undefined) && !this.usersSelected.some(user => user.id == this.creatorSelected.id)) {
      this.creatorSelected = null;
    }

  }

  selectCreator(choices: MatListOption[]) {

    if (choices[0] === undefined) {
      this.creatorSelected = null;
    } else {
      this.creatorSelected = choices[0].value;
    }

  }

  usersSelectedContains(userId: number) {
    return this.usersSelected.some(user => user.id === userId)
  }

  isGroupValidate(minGroupSize: number, maxGroupSize: number): boolean {
    return (this.name !== undefined && this.name.length >= 3 &&
      this.usersSelected.length >= minGroupSize && this.usersSelected.length <= maxGroupSize &&
      this.creatorSelected != undefined && this.creatorSelected != null);
  }

  // ***************************************** //

  submit() {
    this.dialogRef.close({
      name: this.name,
      creator: this.creatorSelected.id,
      members: this.usersSelected.map(user => user.id)
    });
  }

  cancel() {
    this.dialogRef.close();
  }

}
