import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared/shared.module';

import { RegisterComponent } from './pages/register/register.component';

@NgModule({
  declarations: [RegisterComponent],
  imports: [
    CommonModule,
    SharedModule
  ],
  providers: [],
})

export class RegisterModule { }
