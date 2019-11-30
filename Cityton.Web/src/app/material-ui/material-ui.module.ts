import { NgModule } from '@angular/core';

import {
  MatListModule,
  MatSidenavModule,
  MatFormFieldModule,
  MatInputModule,
  MatSelectModule,
  MatButtonToggleModule,
  MatIconModule,
  MatButtonModule
} from '@angular/material';

const modules = [
  MatListModule,
  MatSidenavModule,
  MatFormFieldModule,
  MatInputModule,
  MatSelectModule,
  MatButtonToggleModule,
  MatIconModule,
  MatButtonModule
];

@NgModule({
  imports: [
    modules
  ],
  exports: [modules]
})
export class MaterialUiModule { }
