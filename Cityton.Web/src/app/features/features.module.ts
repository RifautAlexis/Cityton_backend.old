import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';

import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { HomeModule } from './home/home.module';
import { LoginModule } from './login/login.module';
import { RegisterModule } from './register/register.module';

@NgModule({
  declarations: [
  ],
  entryComponents: [
  ],
  imports: [
    HttpClientModule,
    RouterModule,
    SharedModule
  ],
  exports: [
    HttpClientModule,
    RouterModule,
    HomeModule,
    LoginModule,
    RegisterModule
  ]
})

export class FeaturesModule { }
