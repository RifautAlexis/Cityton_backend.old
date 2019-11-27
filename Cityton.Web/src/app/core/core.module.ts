import { NgModule, Optional, SkipSelf } from '@angular/core';
import { SharedModule } from './../shared/shared.module';

import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS, HttpClient } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MaterialUiModule } from "@material/material-ui.module";

import { AuthService } from './services/auth.service';
import { UserService } from './services/user.service';

import { JwtInterceptor } from './interceptors/jwt.interceptor';

import { NavMenuComponent } from './components/nav-menu/nav-menu.component';


@NgModule({
  declarations: [NavMenuComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    RouterModule,
    SharedModule,
    MaterialUiModule
  ],
  providers: [
    AuthService,
    UserService,
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }
  ],
  exports: [
    NavMenuComponent
  ]
})

export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    if (parentModule) {
      throw new Error('CoreModule is already loaded.');
    }
  }
}
