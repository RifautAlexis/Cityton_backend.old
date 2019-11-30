import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { IsConnectedGuard } from '@core/guards/auth.gard/isConnected.guard';
import { IsNotConnectedGuard } from '@core/guards/auth.gard/isnotConnected.guard';


import { NavMenuComponent } from '@core/components/nav-menu/nav-menu.component';
import { HomeComponent } from './home/pages/home/home.component';
import { LoginComponent } from './login/pages/login/login.component';
import { RegisterComponent } from './register/pages/register/register.component';

import { ChatComponent } from './chat/pages/chat/chat.component';
import { SettingsComponent } from './settings/pages/settings/settings.component';
import { IODataComponent } from './admin-space/pages/IO-data/IO-data.component';
import { UserManagementComponent } from './admin-space/pages/user-management/user-management.component';



const routes: Routes = [

  { path: '', component: HomeComponent, canActivate: [IsNotConnectedGuard] },
  { path: 'home', component: HomeComponent, canActivate: [IsNotConnectedGuard] },
  { path: 'home/login', component: LoginComponent, canActivate: [IsNotConnectedGuard] },
  { path: 'login', component: LoginComponent, canActivate: [IsNotConnectedGuard] },
  { path: 'home/register', component: RegisterComponent, canActivate: [IsNotConnectedGuard] },
  { path: 'register', component: RegisterComponent, canActivate: [IsNotConnectedGuard] },

  {
    path: '', component: NavMenuComponent, canActivate: [IsConnectedGuard], children: [

      { path: 'chat:id', component: ChatComponent },
      { path: 'chat', component: ChatComponent },
      { path: 'settings', component: SettingsComponent },
      { path: 'admin', component: UserManagementComponent },
      { path: 'admin/data', component: IODataComponent },
      { path: 'admin/user', component: UserManagementComponent }

    ]
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})

export class FeaturesRoutingModule { }
