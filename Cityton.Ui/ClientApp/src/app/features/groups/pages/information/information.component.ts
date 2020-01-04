import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';
import { ActivatedRoute, Params } from '@angular/router';

import { GroupService } from '@core/services/group.service';

import { IGroupDetails as GroupDetails } from '@shared/models/GroupDetails';

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html',
  styleUrls: ['./information.component.scss']
})
export class InformationComponent implements OnInit {

  group: GroupDetails;
  creator: string;

  constructor(private groupService: GroupService, private activatedRoute: ActivatedRoute) { }

  async ngOnInit() {

    var id: number;

    await this.activatedRoute.params.subscribe(params => {
      id = params.id;
    });

    this.groupService.get(id).subscribe(
      (group: GroupDetails) => {
        console.log(group);
        console.log(group.membershipRequests);
        this.group = group;
        this.creator = group.members.find(user => user.isCreator == true).username;
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
