import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from "@angular/forms";
import { AccountService } from '../services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.page.html',
  styleUrls: ['./register.page.scss'],
})
export class RegisterPage implements OnInit {

  logged = false;
  registerForm: FormGroup;

  message: string;

  constructor(
    public formBuilder: FormBuilder,
    private account: AccountService,
    private router: Router) {
    this.registerForm = this.formBuilder.group({
      nombre:['', [Validators.required, Validators.minLength(2)]],
      apellido:['', [Validators.required, Validators.minLength(2)]],
      mail:['', [Validators.required, Validators.minLength(2)]],
      confirmMail:['', [Validators.required, Validators.minLength(2)]],
      docId:['', [Validators.required, Validators.minLength(2)]],
      fechaNac:['', [Validators.required, Validators.minLength(2)]],
      userName: ['', [Validators.required, Validators.minLength(2)]],
      password: ['', [Validators.required, Validators.minLength(2)]],
      confirmPass:['', [Validators.required, Validators.minLength(2)]]
    });
  }

  ngOnInit() {
  }

  submitForm(){
    let obj = {
      "Nombre": this.registerForm.value["nombre"],
      "Apellido": this.registerForm.value["apellido"],
      "Mail": this.registerForm.value["mail"],
      "DocId": this.registerForm.value["docId"],
      "FechaNac": this.registerForm.value["fechaNac"],
      "User": this.registerForm.value["userName"],
      "Password": this.registerForm.value["password"],
    };

    this.account.Register(obj)
    .subscribe((x:any)=>{
      this.router.navigateByUrl("/auth");
    },(error:any)=>{
      alert(error.statusText);
    });
  }

}
