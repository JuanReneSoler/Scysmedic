import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { AccountService } from '../services/account.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.page.html',
  styleUrls: ['./auth.page.scss'],
})
export class AuthPage implements OnInit {

  loginForm:FormGroup;

  message:string;

  constructor(
    public formBuilder:FormBuilder, 
    private account:AccountService) {
    this.loginForm = this.formBuilder.group({
      userName: ['', [Validators.required, Validators.minLength(2)]],
      password: ['', [Validators.required, Validators.minLength(2)]],
   })
  }

  ngOnInit() {
  }

  submitForm(){
    this.account.LogIn(this.loginForm.value["userName"], this.loginForm.value["password"], false)
    .subscribe((data:any)=>{
      debugger
      console.log(data.error);
    }, (result:any)=>{
      this.message = result.error;
    });
  }

  regist(){
    alert("funciona");
  }
}
