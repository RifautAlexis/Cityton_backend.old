import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';
import { MaterialUiModule } from "@material/material-ui.module";

import { RegisterComponent } from './pages/register/register.component';

@NgModule({
  declarations: [RegisterComponent],
  imports: [
    CommonModule,
    SharedModule,
    MaterialUiModule
  ],
  providers: [],
})

export class RegisterModule { }
