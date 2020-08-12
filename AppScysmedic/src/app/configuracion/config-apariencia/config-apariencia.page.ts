import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-config-apariencia',
  templateUrl: './config-apariencia.page.html',
  styleUrls: ['./config-apariencia.page.scss'],
})
export class ConfigAparienciaPage implements OnInit {

  get page() {
    return {
      title: 'Settings'
    };
  }
  
  dark = false;
  constructor(private modalCtrl: ModalController) {

    const prefersColor = window.matchMedia('(prefers-color-scheme: dark)');
    this.dark = prefersColor.matches;
    this.updateDarkMode();

    prefersColor.addEventListener(
      'change',
      mediaQuery => {
        this.dark = mediaQuery.matches;
        this.updateDarkMode();
      }
    );

  }

  ngOnInit() {
  }
  cerrarSinPasarDatos() {
    this.modalCtrl.dismiss();
  }


  updateDarkMode() {
    document.body.classList.toggle('dark', this.dark);
  }

}
