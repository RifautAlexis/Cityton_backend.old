import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialUiModule } from "@material/material-ui.module";

import { IODataComponent } from './pages/IO-data/IO-data.component';
import { UserManagementComponent } from './pages/user-management/user-management.component';

import { SearchUserComponent } from './components/user-management/search-user/search-user.component';
import { ExportDataComponent } from './components/IO-data/export-data/export-data.component';
import { ImportDatalComponent } from './components/IO-data/import-data/import-data.component';
import { ImportManualComponent } from './components/IO-data/import-manual/import-manual.component';

@NgModule({
  declarations: [
    IODataComponent,
    UserManagementComponent,
    SearchUserComponent,
    ExportDataComponent,
    ImportDatalComponent,
    ImportManualComponent
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
