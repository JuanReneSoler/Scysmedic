import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class AccountService extends BaseService {

  constructor(private http:HttpClient) { super(); }

  LogIn(user:string, pass:string, rMe:boolean){
    
    let obj={
      "userName":user,
      "password":pass,
      "rememberMe":rMe
    }

    return this.http.post(this.BaseUrl+"Account/LogIn", obj);
  }
}
