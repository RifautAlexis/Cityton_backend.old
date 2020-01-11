import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';
import { ActivatedRoute, Params } from '@angular/router';

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
  connectedUser: User;

  isCreator: boolean = false;
  isMember: boolean = false;

  requestId: number = -1; // From membership if the connected user is member of this group, else -1

  constructor(
    private groupService: GroupService,
    private activatedRoute: ActivatedRoute,
    private authService: AuthService) { }

  async ngOnInit() {

    var id: number;

    await this.activatedRoute.params.subscribe(params => {
      id = params.id;
    });

    this.authService.getConnectedUser().subscribe(
      (user: User) => {
        this.connectedUser = user;
      }
    );

    this.groupService.get(id).subscribe(
      (group: GroupDetails) => {

        this.group = group;
        this.creator = group.members.find(user => user.isCreator == true).username;
        this.isCreator = group.members.find(user => user.isCreator == true).userId == this.connectedUser.id;

        let currentMember: any = group.members.find(user => user.userId == this.connectedUser.id); // GroupDetails.IUser
        if (currentMember !== undefined) {
          this.isMember = true;
          this.requestId = currentMember.requestId;
        }
      }
    );

  }

  acceptRequest(requestId: number) {
    this.groupService.acceptRequest(requestId);
  }

  declineRequest(requestId: number) {
    this.groupService.declineRequest(requestId);

  }

  leaveGroup() {
    if (this.isMember) {
      this.groupService.leaveGroup(this.requestId).subscribe();
      this.ngOnInit();
    }
  }

}
