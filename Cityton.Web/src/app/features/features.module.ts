import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { HomeModule } from './home/home.module';
import { LoginModule } from './login/login.module';
import { RegisterModule } from './register/register.module';
import { ChatModule } from './chat/chat.module';
import { SettingsModule } from './settings/settings.module';

import { FeaturesRoutingModule } from './features-routing.module';

@NgModule({
  declarations: [
  ],
  entryComponents: [
  ],
  imports: [
    HttpClientModule,
    RouterModule,
    FeaturesRoutingModule
  ],
  exports: [
    HttpClientModule,
    RouterModule,
    FeaturesRoutingModule,
    HomeModule,
    LoginModule,
    RegisterModule,
    ChatModule,
    SettingsModule
  ]
})

export class FeaturesModule { }
