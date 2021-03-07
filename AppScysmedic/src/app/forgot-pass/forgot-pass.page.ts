import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { AccountService } from '../services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-forgot-pass',
  templateUrl: './forgot-pass.page.html',
  styleUrls: ['./forgot-pass.page.scss'],
})
export class ForgotPassPage implements OnInit {

  logged = false;
  forgotForm: FormGroup;

  message: string;

  constructor(
    public formBuilder: FormBuilder,
    private account: AccountService,
    private router: Router) {
    this.forgotForm = this.formBuilder.group({
      userName: ['', [Validators.required, Validators.minLength(2)]],
      password: ['', [Validators.required, Validators.minLength(2)]],
      confirmPass:['', [Validators.required, Validators.minLength(2)]]
    });
  }

  ngOnInit() {
  }

  submitForm()
  {
    let obj = {
      "User": this.forgotForm.value["userName"],
      "Password": this.forgotForm.value["password"],
    };
    
    this.account.ForgotPass(obj)
    .subscribe((result:any)=>{
      this.router.navigateByUrl("/auth");
    }, (error:any)=>{
      alert(error.statusText);
    });
  }

}



