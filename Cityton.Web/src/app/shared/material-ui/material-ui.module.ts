import { NgModule } from '@angular/core';

import {
  MatListModule,
  MatSidenavModule,
  MatFormFieldModule,
  MatInputModule,
  MatSelectModule,
  MatButtonToggleModule,
  MatIconModule,
  MatButtonModule,
  MatCardModule
} from '@angular/material';

const modules = [
  MatListModule,
  MatSidenavModule,
  MatFormFieldModule,
  MatInputModule,
  MatSelectModule,
  MatButtonToggleModule,
  MatIconModule,
  MatButtonModule,
  MatCardModule
];

@NgModule({
  imports: [
    modules
  ],
  exports: [modules]
})
export class MaterialUiModule { }
