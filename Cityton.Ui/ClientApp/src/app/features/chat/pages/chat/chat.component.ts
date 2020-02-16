import { Component, OnInit, NgZone } from '@angular/core';

import { ChatService } from '@core/services/chat.service';
import { AuthService } from '@core/services/auth.service';

import { IMessage as Message } from '@shared/models/message';
import { Subscription, BehaviorSubject } from 'rxjs';

import { environment } from 'src/environments/environment';

import * as signalR from "@microsoft/signalr";

import { ActivatedRoute, Params, Router } from '@angular/router';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})

export class ChatComponent implements OnInit {

  messages$: BehaviorSubject<Message[]> = new BehaviorSubject([]);
  threadId: number;
  private connectionIsEstablished: boolean = false;

  constructor(
    private chatService: ChatService,
    private authService: AuthService,
    private activatedRoute: ActivatedRoute, ) {
  }

  ngOnInit() {
    this.activatedRoute.paramMap.subscribe(params => {
      this.threadId = Number(params.get("threadId"));

      this.chatService.getMessages(this.threadId).subscribe(
        (messages: Message[]) => {
          console.log(messages);
          this.messages$.next(messages);
        }
      );
    })

    this.subscribeToEvent();
  }

  private subscribeToEvent() {

    this.chatService.connectionEstablished.subscribe(
      (connectionIsEstablished: boolean) => {
        this.connectionIsEstablished = connectionIsEstablished;

        console.log(this.connectionIsEstablished);
      }
    );

    this.chatService.messageReceived.subscribe(
      (newMessage: Message) => {
        this.messages$.next([...this.messages$.value, newMessage]);
      }
    );
}

sendMessage(newMessage: string) {
  console.log("SEND");
  this.chatService.sendMessage(newMessage, this.threadId);
}

ngOnDestroy(): void {
  this.chatService.closeConnection();
}

}
