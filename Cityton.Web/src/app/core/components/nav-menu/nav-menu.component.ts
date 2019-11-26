import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html'
})

export class NavMenuComponent implements OnInit {

  selectedMenu: string = "Settings";
  threads: any;

  constructor() { }

  ngOnInit() {
  }

}
