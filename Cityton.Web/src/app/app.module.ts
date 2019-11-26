import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app.routing';

import { AppComponent } from './app.component';

import { FeaturesModule } from '@features/features.module';
import { CoreModule } from '@core/core.module';

import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
@NgModule({
   declarations: [
      AppComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      CoreModule,
      FeaturesModule,
      BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
