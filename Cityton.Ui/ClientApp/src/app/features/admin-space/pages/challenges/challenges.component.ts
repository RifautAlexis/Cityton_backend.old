import { Component, OnInit } from '@angular/core';

import { Router, ActivatedRoute } from '@angular/router';
import { Observable, of } from 'rxjs';

import { ChallengeService } from '@core/services/challenge.service';

import { IChallenge as Challenge } from '@shared/models/Challenge';

import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-challenges',
  templateUrl: './challenges.component.html',
  styleUrls: ['./challenges.component.scss']
})
export class ChallengesComponent implements OnInit {

  challengesToApprove$: Observable<Challenge[]>;

  challengesSearched$: Observable<Challenge[]> = of([]);
  searchField: string = "";

  constructor(
    private challengeService: ChallengeService,
    private router: Router,
    private route: ActivatedRoute,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.refreshWaitingChallenges();

    this.searchField = this.route.snapshot.queryParamMap.get('toSearch');

    if (this.searchField !== "" && this.searchField !== null && this.searchField.length !== 0) {
      this.search();
    }
  }

  delete(challengeId: number) {

    this.challengeService.delete(challengeId).subscribe(
      () => {
        this.refreshWaitingChallenges();
      }
    );

  }

  edit(data: any) {
    this.challengeService.edit(data.id, data.name, data.statement).subscribe(
      (result: any) => {
        this.refreshWaitingChallenges();
      }
    );
  }

  validate(challengeId: number) {
    this.challengeService.validate(challengeId).subscribe(
      () => {
        this.refreshWaitingChallenges();
      }
    );
  }

  private refreshWaitingChallenges() {
    this.challengesToApprove$ = this.challengeService.getAllWaiting();
  }

  private search() {
    this.challengesSearched$ = this.challengeService.searchChallenges(this.searchField);
  }

  private searchGroup(toSearch: string) {
    this.searchField = toSearch;

    this.search();
  }

}
