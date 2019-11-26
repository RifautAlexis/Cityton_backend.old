import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './pages/home/home.component';

import { IsNotConnectedGuard } from '@core/guards/auth.gard/isNotConnected.guard';

const routes: Routes = [
    { path: '',   component: HomeComponent, canActivate: [IsNotConnectedGuard] },
    { path: 'home',   component: HomeComponent, canActivate: [IsNotConnectedGuard] }
  ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class HomeRoutingModule { }
