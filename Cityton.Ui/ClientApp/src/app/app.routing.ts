import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { IsConnectedGuard } from '@core/guards/auth.gard/isConnected.guard';
import { IsNotConnectedGuard } from '@core/guards/auth.gard/isNotConnected.guard';

import { NavMenuComponent } from '@core/components/nav-menu/nav-menu.component';
import { HomeComponent } from '@features/home/pages/home/home.component';

import { ChatModule } from '@features/chat/chat.module';
import { SettingsModule } from '@features/settings/settings.module';
import { AdminSpaceModule } from '@features/admin-space/admin-space.module';
import { GroupsModule } from '@features/groups/groups.module';


const routes: Routes = [

  { path: '', component: HomeComponent, canActivate: [IsNotConnectedGuard] },
  { path: 'home', component: HomeComponent, canActivate: [IsNotConnectedGuard] },

  {
    path: '', component: NavMenuComponent, canActivate: [IsConnectedGuard], children: [

      { path: 'chat', loadChildren: () => ChatModule },
      { path: 'settings', loadChildren: () => SettingsModule },
      { path: 'admin', loadChildren: () => AdminSpaceModule },
      { path: 'groups', loadChildren: () => GroupsModule }

    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
