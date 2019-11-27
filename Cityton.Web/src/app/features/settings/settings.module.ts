import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';
import { MaterialUiModule } from "@material/material-ui.module";

import { SettingsComponent } from './pages/settings/settings.component';

@NgModule({
  declarations: [SettingsComponent],
  imports: [
    CommonModule,
    SharedModule,
    MaterialUiModule
  ],
  providers: [],
})

export class SettingsModule { }
