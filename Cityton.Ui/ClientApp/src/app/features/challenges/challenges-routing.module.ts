import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AllChallengesComponent } from './pages/all-challenges/all-challenges.component';
import { GlobalStatsComponent } from './pages/global-stats/global-stats.Component';

import { IsMemberGuard } from '@core/guards/isMember.guard';

const routes: Routes = [
    { path: '', component: AllChallengesComponent, canActivate: [IsMemberGuard] },
    { path: 'stats', component: GlobalStatsComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class ChallengesRoutingModule { }
