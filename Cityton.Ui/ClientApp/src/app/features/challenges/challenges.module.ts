import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';

import { ChallengesRoutingModule } from './challenges-routing.module';

import { AllChallengesComponent } from './pages/all-challenges/all-challenges.component';

@NgModule({
  declarations: [
    AllChallengesComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ChallengesRoutingModule
  ],
  entryComponents: [
  ],
  providers: [
  ],
})

export class ChallengesModule { }
