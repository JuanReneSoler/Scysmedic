import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-configuracion',
  templateUrl: './configuracion.page.html',
  styleUrls: ['./configuracion.page.scss'],
})
export class ConfiguracionPage implements OnInit {
  
  darkMode: boolean = true;

  constructor() { 
    const prefersDark = window.matchMedia('(prefers-color-scheme: dark)');
    this.darkMode = prefersDark.matches;
  }


  ngOnInit() {
  }


  //Dark mode on-off


  toggleDarkMode() {
    console.log(window.matchMedia('(prefers-color-scheme: dark)'));
    this.darkMode = !this.darkMode;
    document.body.classList.toggle( 'dark' );
  }
}
