import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';

import { ChallengeService } from '@core/services/challenge.service';

import { IChallengeList as ChallengeList } from '@shared/models/ChallengeList';

@Component({
  selector: 'app-all-challenges',
  templateUrl: './all-challenges.component.html',
  styleUrls: ['./all-challenges.component.scss']
})
export class AllChallengesComponent implements OnInit {

  challengeList$: Observable<ChallengeList>;

  constructor(private challengeService: ChallengeService) { }

  ngOnInit() {
    this.challengeList$ = this.challengeService.getAll();
  }

}
