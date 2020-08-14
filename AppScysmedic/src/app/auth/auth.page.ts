import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { AccountService } from '../services/account.service';
import { MenuController } from '@ionic/angular';
import { Router } from '@angular/router';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.page.html',
  styleUrls: ['./auth.page.scss'],
})
export class AuthPage implements OnInit {

  logged = false;
  loginForm: FormGroup;

  message: string;

  constructor(
    public formBuilder: FormBuilder,
    private account: AccountService, 
    private menuCtrl: MenuController,
    private router: Router) {
    this.loginForm = this.formBuilder.group({
      userName: ['', [Validators.required, Validators.minLength(2)]],
      password: ['', [Validators.required, Validators.minLength(2)]],
    })
  }

  ngOnInit() {
    this.menuCtrl.enable(false);
  }

  submitForm() {
    this.account.LogIn(this.loginForm.value["userName"], this.loginForm.value["password"], false)
      .subscribe((data: any) => {
        this.router.navigateByUrl("/home/citas");
      }, (result: any) => {
        this.message = result.error;
      });
  }
}
