import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';
import { AuthService } from '@core/services/auth.service';

import { IUser as User } from '@shared/models/User';

@Component({
  selector: 'app-change-picture',
  templateUrl: './change-picture.component.html'
})

export class ChangePictureComponent implements OnInit {

  url: string | ArrayBuffer = '';
  fileData: File;

  constructor(private userService: UserService, private authService: AuthService) { }

  ngOnInit() {
    this.url = this.authService.currentUserValue().picture;
  }

  preview(files: FileList) {

    if (files && files[0]) {

      this.fileData = files[0];

      var reader = new FileReader();

      reader.readAsDataURL(files[0]); // read file as data url

      reader.onload = (event: any) => { // called once readAsDataURL is completed
        this.url = event.target.result;
      }

    }
  }

  onSelectFile() {

    if (this.fileData) {

      let currentUser: User = this.authService.currentUserValue();

      this.userService.uploadPicture(this.fileData, currentUser.id)
      .subscribe(
        (pathPicture: string) => {
          currentUser.picture = pathPicture;
          this.url = pathPicture;
          this.authService.updateCurrentUser(currentUser);
        }
      );

    }
  }

  delete() {
    this.url = null;
  }

}
