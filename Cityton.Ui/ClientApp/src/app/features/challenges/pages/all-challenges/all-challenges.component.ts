import { map } from 'rxjs/operators';
import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';

import { ChallengeService } from '@core/services/challenge.service';

import { IChallenge as Challenge } from '@shared/models/Challenge';

@Component({
  selector: 'app-all-challenges',
  templateUrl: './all-challenges.component.html',
  styleUrls: ['./all-challenges.component.scss']
})
export class AllChallengesComponent implements OnInit {

  challengeList$: Observable<Challenge[]>;
  unlockedChallenges: Challenge[];
  lockedChallenges: Challenge[];

  constructor(private challengeService: ChallengeService) { }

  ngOnInit() {
    this.challengeList$ = this.challengeService.getAll();

    this.challengeList$.subscribe(
      (challenges: Challenge[]) => {
        this.unlockedChallenges = challenges.filter(ch => ch.unlockedAt !== null);
        this.lockedChallenges = challenges.filter(ch => ch.unlockedAt === null);
      }
    );
  }

}
