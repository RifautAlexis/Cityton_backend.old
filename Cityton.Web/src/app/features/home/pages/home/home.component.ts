import { Component, OnInit } from '@angular/core';

import { MatDialog } from '@angular/material';

import { LoginComponent } from '@features/home/components/login/login.component';
import { SignupComponent } from '@features/home/components/signup/signup.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {

  constructor(
    public dialog: MatDialog
  ) { }

  ngOnInit() {
  }

  openLogin(): void {
    this.dialog.open(LoginComponent, {
      width: 'auto'
    });
  }

  openSignup(): void {
    this.dialog.open(SignupComponent, {
      width: 'auto'
    });
  }

}
