import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { BaseService } from './base.service';
import { HttpHeaders } from '@angular/common/http';

// const httpOptions = {
//   headers: new HttpHeaders({ 
//     'Access-Control-Allow-Origin':'*',
//     'Authorization':'authkey',
//     'userid':'1'
//   })
// };

@Injectable({
  providedIn: 'root'
})
export class AccountService extends BaseService {

  constructor(private http:HttpClient) {super(); this.http}

  LogIn(user:string, pass:string, rMe:boolean){
    
    let obj={
      "userName":user,
      "password":pass,
      "rememberMe":rMe
    }

    return this.http.post(this.BaseUrl+"Account/LogIn", obj);
  }

}
