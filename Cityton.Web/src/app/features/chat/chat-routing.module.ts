import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ChatComponent } from './pages/chat/chat.component';

import { IsConnectedGuard } from '@core/guards/auth.gard/isConnected.guard';
import { NavMenuComponent } from '@core/components/nav-menu/nav-menu.component';

const routes: Routes = [
  {
    path: '', component: NavMenuComponent, canActivate: [IsConnectedGuard], children: [

      { path: 'chat', component: ChatComponent, canActivate: [IsConnectedGuard] },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class ChatRoutingModule { }
