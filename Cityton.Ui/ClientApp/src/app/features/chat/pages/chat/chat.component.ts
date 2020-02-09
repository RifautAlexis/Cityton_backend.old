import { Component, OnInit, NgZone } from '@angular/core';

import { ChatService } from '@core/services/chat.service';
import { AuthService } from '@core/services/auth.service';

import { IMessage as Message } from '@shared/models/message';
import { Subscription, BehaviorSubject } from 'rxjs';

import { environment } from 'src/environments/environment';

import * as signalR from "@microsoft/signalr";

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})

export class ChatComponent implements OnInit {

  private hubConnection: signalR.HubConnection;

  messages$: BehaviorSubject<Message[]> = new BehaviorSubject([]);

  constructor(private chatService: ChatService, private authService: AuthService) {
  }

  ngOnInit() {
    this.openConnection();

    let connectedUserId: number = this.authService.getUserId();
    this.chatService.getMessages(1).subscribe(
      (messages: Message[]) => {
        this.messages$.next(messages);
      }
    );

    this.hubConnection.on("messageReceived", (newMessage: Message) => {
      this.messages$.next([...this.messages$.value, newMessage]);
    });
  }

  openConnection() {
    this.hubConnection = new signalR.HubConnectionBuilder()
    .configureLogging(signalR.LogLevel.Debug)
      .withUrl('http://localhost:5000/hub/chatHub', { accessTokenFactory: () => this.authService.currentTokenValue() })
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection started!'))
      .catch(err => console.log(err));
  }

  sendMessage(newMessage: string, discussionId: number) {
    console.log("SEND");
    this.hubConnection
      .send("newMessage", newMessage, 1)
      .then(lol => console.log(lol));
  }

  ngOnDestroy(): void {
    this.hubConnection.stop();
  }

}
