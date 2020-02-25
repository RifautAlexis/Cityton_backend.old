import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { IChallengeChat as ChallengeChat } from '@shared/models/ChallengeChat';

@Component({
  selector: 'app-challenges',
  templateUrl: './challenges.component.html',
  styleUrls: ['./challenges.component.scss']
})
export class ChallengesComponent implements OnInit {

  @Input() challenges: ChallengeChat[];

  @Output() toValidate: EventEmitter<number> = new EventEmitter();
  @Output() toReject: EventEmitter<number> = new EventEmitter();
  @Output() toUndo: EventEmitter<number> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  validate(challengeGivenId) {
    this.toValidate.emit(challengeGivenId);
  }

  reject(challengeGivenId) {
    this.toValidate.emit(challengeGivenId);
  }

  undo(challengeGivenId) {
    this.toValidate.emit(challengeGivenId);
  }
}
