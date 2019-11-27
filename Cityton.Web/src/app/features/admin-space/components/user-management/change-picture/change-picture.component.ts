import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormGroup, NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { UserService } from '@core/services/user.service';

@Component({
  selector: 'app-change-picture',
  templateUrl: './change-picture.component.html'
})
export class ChangePictureComponent implements OnInit {

  pictureForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private userService: UserService) { }

  ngOnInit() {
  }

  onSubmit() {

  }

  cancel(formToReset: NgForm) {
    formToReset.reset();
  }

}
