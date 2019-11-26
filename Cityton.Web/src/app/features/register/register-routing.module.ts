import { IsNotConnectedGuard } from './../../core/guards/auth.gard/isNotConnected.guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RegisterComponent } from './pages/register/register.component';

const routes: Routes = [
    { path: 'home/register',   component: RegisterComponent, canActivate: [IsNotConnectedGuard] },
    { path: 'register',   component: RegisterComponent, canActivate: [IsNotConnectedGuard] }
  ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class RegisterRoutingModule { }
