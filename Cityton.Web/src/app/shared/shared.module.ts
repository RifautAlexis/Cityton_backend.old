import { NgModule } from '@angular/core';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MaterialUiModule } from '@shared/material-ui/material-ui.module';


@NgModule({
  declarations: [
  ],
  entryComponents: [
  ],
  imports: [
    HttpClientModule,
    RouterModule,
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialUiModule
  ],
  exports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
    MaterialUiModule
  ]
})

export class SharedModule { }
