import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './pages/login/login.component';
import { IsNotConnectedGuard } from '@core/guards/auth.gard/isNotConnected.guard';

const routes: Routes = [
    { path: 'home/login',   component: LoginComponent, canActivate: [IsNotConnectedGuard] },
    { path: 'login',   component: LoginComponent, canActivate: [IsNotConnectedGuard] }
  ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class LoginRoutingModule { }
