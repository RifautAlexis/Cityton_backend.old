import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialUiModule } from "@material/material-ui.module";

import { IODataComponent } from './pages/IO-data/IO-data.component';
import { UserManagementComponent } from './pages/user-management/user-management.component';

import { ChangeUsernameComponent } from './components/user-management/change-username/change-username.component';
import { ChangePhoneNumberComponent } from './components/user-management/change-phoneNumber/change-phoneNumber.component';
import { ChangeEmailComponent } from './components/user-management/change-email/change-email.component';
import { ChangePasswordComponent } from './components/user-management/change-password/change-password.component';
import { ChangePictureComponent } from './components/user-management/change-picture/change-picture.component';


@NgModule({
  declarations: [
    ChangeUsernameComponent,
    ChangePhoneNumberComponent,
    ChangeEmailComponent,
    ChangePasswordComponent,
    ChangePictureComponent,
    IODataComponent,
    UserManagementComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    SharedModule,
    MaterialUiModule
  ],
  providers: [],
})

export class AdminSpaceModule { }
