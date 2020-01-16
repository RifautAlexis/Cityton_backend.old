import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';

import { AdminSpaceRoutingModule } from './admin-space-routing.module';

import { IODataComponent } from './pages/IO-data/IO-data.component';
import { UserManagementComponent } from './pages/user-management/user-management.component';
import { GroupsComponent } from './pages/groups/groups.component';

import { SearchUserComponent } from './components/user-management/search-user/search-user.component';
import { EditUserComponent } from './components/user-management/edit-user/edit-user.component';
import { ExportDataComponent } from './components/IO-data/export-data/export-data.component';
import { ImportDatalComponent } from './components/IO-data/import-data/import-data.component';
import { ImportManualComponent } from './components/IO-data/import-manual/import-manual.component';
import { SearchGroupsComponent } from './components/groups/search-groups/search-groups.component';

@NgModule({
  declarations: [
    IODataComponent,
    UserManagementComponent,
    SearchUserComponent,
    EditUserComponent,
    ExportDataComponent,
    ImportDatalComponent,
    ImportManualComponent,
    GroupsComponent,
    SearchGroupsComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    AdminSpaceRoutingModule
  ],
  entryComponents: [
    EditUserComponent
  ],
  providers: [],
})

export class AdminSpaceModule { }
