import { EventEmitter, Injectable, RootRenderer } from '@angular/core';

import { environment } from 'src/environments/environment';

import { HubConnection, HubConnectionBuilder } from '@Microsoft/signalr';
import { HttpClient } from '@angular/common/http';
import { IMessage as Message } from '@shared/models/message';
import { Subject, Observable } from 'rxjs';

import * as signalR from "@microsoft/signalr";

@Injectable({
  providedIn: 'root'
})
export class ChatService {

  constructor() {
  }

}
