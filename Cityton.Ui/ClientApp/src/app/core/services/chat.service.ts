import { EventEmitter, Injectable } from '@angular/core';

import { environment } from 'src/environments/environment';

import { HubConnection, HubConnectionBuilder } from '@Microsoft/signalr';
import { HttpClient } from '@angular/common/http';
// import { Message } from '../models/message';

@Injectable()
export class ChatService {

  private hubConnection: HubConnection;

  constructor(private http: HttpClient) { }

  public openConnection() {

    this.hubConnection = new HubConnectionBuilder()
      .withUrl('http://localhost:5000/hubs/chatHub')
      .build();

    this.hubConnection
      .start()
      .then(() => console.log('Connection started!'))
      .catch(err => console.log(err));

  }

  public getHubConnection(): HubConnection {
    return this.hubConnection;
  }

  public sendMessage(message: string): Promise<string> {

    return this.http.post<string>(environment.apiUrl + `chathub/sendMessage`, message).toPromise();
  }


  // messageReceived = new EventEmitter<string>();
  // connectionEstablished = new EventEmitter<Boolean>();

  // private connectionIsEstablished = false;
  // private _hubConnection: HubConnection;

  // constructor() {
  //   this.createConnection();
  //   this.registerOnServerEvents();
  //   this.startConnection();
  // }

  // sendMessage(message: string) {
  //   this._hubConnection.invoke('NewMessage', message);
  // }

  // private createConnection() {
  //   this._hubConnection = new HubConnectionBuilder()
  //     .withUrl(environment.apiUrl + 'ChatHub')
  //     .build();
  // }

  // private startConnection(): void {
  //   this._hubConnection
  //     .start()
  //     .then(() => {
  //       this.connectionIsEstablished = true;
  //       console.log('Hub connection started');
  //       this.connectionEstablished.emit(true);
  //     })
  //     .catch(err => {
  //       console.log('Error while establishing connection, retrying...');
  //       setTimeout(function () { this.startConnection(); }, 5000);
  //     });
  // }

  // private registerOnServerEvents(): void {
  //   this._hubConnection.on('ReceiveMessage', (data: any) => {
  //     console.log(data);
  //     this.messageReceived.emit(data);
  //   });
  // }
}
