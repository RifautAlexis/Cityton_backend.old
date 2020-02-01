import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';

import { ChallengeService } from '@core/services/challenge.service';

import { IChallengeList as ChallengeList } from '@shared/models/ChallengeList';

@Component({
  selector: 'app-global-stats',
  templateUrl: './global-stats.component.html',
  styleUrls: ['./global-stats.component.scss']
})

export class GlobalStatsComponent implements OnInit {

  challengeList$: Observable<ChallengeList>;

  constructor(private challengeService: ChallengeService) { }

  ngOnInit() {
    this.challengeList$ = this.challengeService.getAll();
  }

}
