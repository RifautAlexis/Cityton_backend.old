import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '@core/services/auth.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.scss']
})

export class NavMenuComponent implements OnInit {

  selectedMenu: string = "Settings";
  threads: any;

  constructor(private authService: AuthService, private router: Router) { }

  ngOnInit() {
  }

  selectMenu(menu: string) {
    this.selectedMenu = menu;
  }

  logout() {
    this.authService.logout();
    this.router.navigate(['']);
  }

}
