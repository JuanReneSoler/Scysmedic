import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class CitaService {

  url = 'https://pokeapi.co/api/v2/pokemon/';

  constructor(private http: HttpClient) { }

  search(title: string){
    return this.http.get(`${this.url}${title}`);
  }

}
