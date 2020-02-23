import { NgModule } from '@angular/core';
import { SharedModule } from '@shared/shared.module';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { ChatRoutingModule } from './chat-routing.module';

import { ChatRoomComponent } from './pages/chat-room/chat-room.component';

import { ChatComponent } from './components/chat/chat.component';
import { ChallengesComponent } from './components/challenges/challenges.component';

@NgModule({
  declarations: [
    ChatRoomComponent,
    ChatComponent,
    ChallengesComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    SharedModule,
    ChatRoutingModule
  ],
  providers: [],
})

export class ChatModule { }
