import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { IsConnectedGuard } from '@core/guards/auth.gard/isConnected.guard';
import { IsNotConnectedGuard } from '@core/guards/auth.gard/isNotConnected.guard';

import { NavMenuComponent } from '@core/components/nav-menu/nav-menu.component';
import { HomeComponent } from '@features/home/pages/home/home.component';
import { LoginComponent } from '@features/login/pages/login/login.component';
import { RegisterComponent } from '@features/register/pages/register/register.component';

import { ChatComponent } from '@features/chat/pages/chat/chat.component';
import { SettingsComponent } from '@features/settings/pages/settings/settings.component';
import { IODataComponent } from '@features/admin-space/pages/IO-data/IO-data.component';
import { UserManagementComponent } from '@features/admin-space/pages/user-management/user-management.component';

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
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
