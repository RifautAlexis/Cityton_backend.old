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
        this.isCreator = group.members.find(user => user.isCreator == true).id == this.connectedUser.id;
        group.members.find(user => user.id == this.connectedUser.id) === undefined ? this.isMember = false : this.isMember = true;
      }
    );

  }

  acceptRequest(requestId: number) {
    this.groupService.acceptRequest(requestId);
  }

  declineRequest(requestId: number) {
    this.groupService.declineRequest(requestId);

  }

}
