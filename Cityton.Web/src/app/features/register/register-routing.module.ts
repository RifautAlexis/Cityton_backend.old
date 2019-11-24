import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { RegisterComponent } from './pages/register/register.component';

const routes: Routes = [
    { path: 'home/register',   component: RegisterComponent },
    { path: 'register',   component: RegisterComponent }
  ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class RegisterRoutingModule { }
