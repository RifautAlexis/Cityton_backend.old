import { Component, OnInit } from '@angular/core';

import { Router, ActivatedRoute } from '@angular/router';

import { ChatService } from '@core/services/chat.service';
import { Observable } from 'rxjs';

import { IChallengeChat as ChallengeChat } from '@shared/models/ChallengeChat';

@Component({
    selector: 'app-chat-room',
    templateUrl: './chat-room.component.html',
    styleUrls: ['./chat-room.component.scss']
})
export class ChatRoomComponent implements OnInit {

    threadId: number;

    challenges$: Observable<ChallengeChat>;

    constructor(
        private chatService: ChatService,
        private activatedRoute: ActivatedRoute
    ) { }

    ngOnInit() {

        this.activatedRoute.paramMap.subscribe(params => {
            this.threadId = Number(params.get("threadId"));

            console.log(params.get("threadId"));

            this.challenges$ = this.chatService.getChallenges(this.threadId);

            this.challenges$.subscribe(
                (lol) => {console.log(lol);}
            )
            
        })

        
    }

}
