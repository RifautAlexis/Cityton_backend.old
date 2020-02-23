import { Component, OnInit, Input } from '@angular/core';

import { IChallenge as Challenge } from '@shared/models/Challenge';

@Component({
  selector: 'app-challenges',
  templateUrl: './challenges.component.html',
  styleUrls: ['./challenges.component.scss']
})
export class ChallengesComponent implements OnInit {

  @Input() challengesSearched: Challenge[];

  constructor() { }

  ngOnInit() {
  }

}
