import { Component, OnInit } from '@angular/core';

import { Observable, BehaviorSubject, pipe } from 'rxjs';
import { ActivatedRoute, Params, Router } from '@angular/router';

import { GroupService } from '@core/services/group.service';
import { AuthService } from '@core/services/auth.service';

import { IGroupDetails as GroupDetails } from '@shared/models/GroupDetails';
import { IUser as User } from '@shared/models/User';

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html',
  styleUrls: ['./information.component.scss']
})
export class InformationComponent implements OnInit {

  group: GroupDetails;
  creator: string;
  connectedUserId: string;

  isCreator: boolean = false;
  isMember: boolean = false;

  requestId: number = -1; // From membership if the connected user is member of this group, else -1

  constructor(
    private groupService: GroupService,
    private activatedRoute: ActivatedRoute,
    private authService: AuthService,
    private router: Router) { }

  ngOnInit() {

    this.connectedUserId = this.authService.getUserId();

    this.refresh();

  }

  acceptRequest(requestId: number) {
    if (this.isCreator) {
      this.groupService.acceptRequest(requestId);
      this.refresh();
    }
  }

  declineRequest(requestId: number) {
    if (this.isCreator) {
      this.groupService.declineRequest(requestId);
      this.refresh();
    }
  }

  leaveGroup() {
    if (this.isMember) {
      this.groupService.leaveGroup(this.requestId).subscribe(
        () => {
          if (this.isCreator)
            this.router.navigate(['groups']);
          else
            this.refresh();
        }
      );
    }
  }

  private refresh() {

    const id: string = this.activatedRoute.snapshot.paramMap.get("id");

    this.groupService.get(id).subscribe(
      (group: GroupDetails) => {

        this.group = group;
        this.isCreator = group.creatorId == Number(this.connectedUserId);

        let currentMember: any = group.members.find(user => user.userId == Number(this.connectedUserId)); // GroupDetails.IUser
        if (currentMember !== undefined) {
          this.isMember = true;
          this.requestId = currentMember.requestId;

        } else {
          this.isMember = false;
          this.requestId = -1;
        }

      }
    );
  }

}
