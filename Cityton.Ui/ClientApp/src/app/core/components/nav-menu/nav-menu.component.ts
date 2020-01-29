import { Component, OnInit } from '@angular/core';

import { Router } from '@angular/router';

import { AuthService } from '@core/services/auth.service';
import { UserService } from '@core/services/user.service';

import { IUser as User } from '@shared/models/User';
import { Role } from '@shared/models/Enum';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.scss']
})

export class NavMenuComponent implements OnInit {

  selectedMenu: string = "Settings";
  threads: any;
  info: any;

  isInAGroup: boolean;
  isAMember: boolean;
  isAdmin: boolean;

  constructor(
    private authService: AuthService,
    private router: Router,
    private userService: UserService
  ) { }

  ngOnInit() {
    this.isAdmin = this.authService.getUserRole() === Role.Admin;

  }

  selectMenu(menu: string) {

    switch (menu) {
      case "Groups": {
        this.authService.getConnectedUser().subscribe(
          (user: User) => {
            this.info = user;
            this.isInAGroup = user.groupId > 0;
            this.isAMember = user.role == Role.Member;
          }
        );

      }
      default: {
        //statements;
        break;
      }

    }

    this.selectedMenu = menu;
  }

  ToMyGroup() {
    this.router.navigate(['groups/details', this.info.groupId]);
  }

  logout() {
    this.authService.logout();
    this.router.navigate(['']);
  }

}
