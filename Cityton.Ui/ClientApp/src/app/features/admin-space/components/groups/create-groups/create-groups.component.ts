import { Component, OnInit, Inject, EventEmitter, Output } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatListOption } from '@angular/material';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';

import { UserService } from '@core/services/user.service';
import { CompanyService } from '@core/services/company.service';

import { IUserMinimal as UserMinimal } from '@shared/models/UserMinimal';
import { ICompany as Company } from '@shared/models/Company';

import { Observable, of } from 'rxjs';

@Component({
  selector: 'app-create-groups',
  templateUrl: './create-groups.component.html',
  styleUrls: ['./create-groups.component.scss']
})
export class CreateGroupsComponent implements OnInit {

  name: string;

  users$: Observable<UserMinimal[]>;
  settings: Company;

  users: UserMinimal[];           // Base
  usersSelected: UserMinimal[] = [];

  usersRemaining: UserMinimal[];  // Removed from users selected
  filteredUsers: UserMinimal[];   // Based on usersRemaining && string searched

  constructor(
    public dialogRef: MatDialogRef<CreateGroupsComponent>,
    private userService: UserService,
    private companyService: CompanyService
  ) { }

  ngOnInit() {

    this.getUsersWithoutGroups("");

    this.companyService.getSettings().subscribe(
      (settings: Company) => {
        this.settings = settings;
      }
    );

  }

  selectUser(choices: MatListOption[]) {

    this.usersSelected = choices.map(choice => choice.value);
    this.usersSelected.forEach(element => {
      console.log(element.id);
    });

  }

  usersSelectedContains(userId: number) {
    return this.usersSelected.some(user => user.id === userId)
  }

  // ***************************************** //

  // usersToAdd(): FormArray {
  //   return this.createGroupForm.get("usersToAdd") as FormArray
  // }

  // newField(): FormGroup {
  //   return this.formBuilder.group({
  //     id: ''
  //   })
  // }

  // addField() {
  //   this.usersToAdd().push(this.newField());
  // }

  // removeField(index:number) {
  // //   if (condition) {
  // //     this.createGroupForm.controls['usersToAdd']
  // //   }
  //   console.log(this.createGroupForm.controls['usersToAdd'].value[index]);
  //   this.usersToAdd().removeAt(index);
  // }

  // ***************************************** //

  submit() {
    this.dialogRef.close({
      // name: this.name,
      // creator: this.creator.id
      // members: this.selectedUsers
    });
  }

  cancel() {
    this.dialogRef.close();
  }

  // ***************************************** //

  getUsersWithoutGroups(toSearch: string) {
    this.users$ = this.userService.getUsersWithoutGroup(toSearch);
  }

  // selectUser(userId: number) {
  //   // this.createGroupForm.controls['usersToAdd'].value[indexField] = userId;
  //   this.filteredUsers = this.usersRemaining = this.usersRemaining.filter(option => option.id != userId);
  //   // console.log(this.createGroupForm.controls['usersToAdd'].value[indexField]);
  //   console.log(this.createGroupForm.controls['creator'].value);
  // }

  // filter(toSearch: string) {
  //   const filterValue = toSearch.toLowerCase();

  //   this.filteredUsers = this.usersRemaining.filter(option => option.username.toLowerCase().includes(filterValue));
  // }

  // resetCreator() {
  //   this.createGroupForm.controls['creator'].reset();
  // }

}
