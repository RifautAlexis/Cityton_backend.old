import { Component, OnInit, Input } from '@angular/core';

import { IChallengeChat as ChallengeChat } from '@shared/models/ChallengeChat';

@Component({
  selector: 'app-challenges',
  templateUrl: './challenges.component.html',
  styleUrls: ['./challenges.component.scss']
})
export class ChallengesComponent implements OnInit {

  @Input() challenges: ChallengeChat[];

  constructor() { }

  ngOnInit() {
  }

}
