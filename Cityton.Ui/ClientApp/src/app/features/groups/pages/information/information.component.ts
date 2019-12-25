import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';
import { ActivatedRoute, Params } from '@angular/router';

import { GroupService } from '@core/services/group.service';

import { IGroup as Group } from '@shared/models/Group';

@Component({
  selector: 'app-information',
  templateUrl: './information.component.html',
  styleUrls: ['./information.component.scss']
})
export class InformationComponent implements OnInit {

  group: Group;
  creator: string;

  constructor(private groupService: GroupService, private activatedRoute: ActivatedRoute) { }

  async ngOnInit() {

    var id: number;

    // Route parameters
    await this.activatedRoute.params.subscribe(params => {
      id = params.id;
    });

    console.log(id);

    // URL query parameters
    // this.activatedRoute.queryParams.subscribe( params => {
    //   this.queryParams = params;
    // });

    this.groupService.get(id).subscribe(
      (group: Group) => {
        this.group = group;
        this.creator = group.members.find(user => user.isCreator == true).username;
      }
    );


  }

}
