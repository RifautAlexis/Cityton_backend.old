import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AllChallengesComponent } from './pages/all-challenges/all-challenges.component';

const routes: Routes = [
    { path: '', component: AllChallengesComponent }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

export class ChallengesRoutingModule { }
