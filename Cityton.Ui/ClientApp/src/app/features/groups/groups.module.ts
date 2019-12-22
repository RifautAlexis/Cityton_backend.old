import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';

import { AllGroupsComponent } from './pages/all-groups/all-groups.component';
import { InformationComponent } from './pages/information/information.component';
import { CreateComponent } from './pages/create/create.component';

@NgModule({
  declarations: [
    AllGroupsComponent,
    InformationComponent,
    CreateComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ],
  entryComponents: [
  ],
  providers: [],
})

export class GroupsModule { }
