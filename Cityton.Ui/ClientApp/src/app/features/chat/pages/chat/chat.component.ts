import { Component, OnInit, NgZone } from '@angular/core';

import { ChatService } from '@core/services/chat.service';

import { IMessage as Message } from '@shared/models/message';
import { Subscription } from 'rxjs';

import { environment } from 'src/environments/environment';

import * as signalR from "@microsoft/signalr";

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})

export class ChatComponent implements OnInit {

  private hubConnection: signalR.HubConnection;

  constructor(private chatService: ChatService) {
  }

  ngOnInit() {
    this.openConnection();

    this.hubConnection.on("messageReceived", (text: string) => {
      console.log("QQQQQQQQQ " + text + " PPPPPPPPPPPPPMMMMMMMMMM")
    });
  }

  openConnection() {
    this.hubConnection = new signalR.HubConnectionBuilder()
    .configureLogging(signalR.LogLevel.Debug)
      .withUrl('http://localhost:5000/hub/chatHub', {
        // skipNegotiation: true,
        // transport: signalR.HttpTransportType.WebSockets
      })
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection started!'))
      .catch(err => console.log(err));
  }

  sendMessage(text: string) {
    console.log(text);
    this.hubConnection
      .send("newMessage", text)
      .then(text => console.log(text));

    // this.chatService.send();
  }

  // ngOnDestroy(): void {
  //   this.chatService.disconnect();
  // }

}
