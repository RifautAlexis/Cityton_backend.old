import { Component, OnInit } from '@angular/core';

import { Router, ActivatedRoute } from '@angular/router';

import { ChatService } from '@core/services/chat.service';
import { Observable } from 'rxjs';

import { IChallengeChat as ChallengeChat } from '@shared/models/ChallengeChat';

import { StatusChallenge } from '@shared/models/Enum';

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

      this.refreshChallenges();

    })


  }

  refreshChallenges() {
    this.challenges$ = this.chatService.getChallenges(this.threadId);
  }

  updateChallenge({challengeGivenId, newStatus}) {
    this.chatService.updateChallengeGiven(challengeGivenId, newStatus).subscribe(
      (result: any) => {
        this.refreshChallenges();
      }
    );
  }
}
