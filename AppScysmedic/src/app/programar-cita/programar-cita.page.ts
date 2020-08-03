import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-programar-cita',
  templateUrl: './programar-cita.page.html',
  styleUrls: ['./programar-cita.page.scss'],
})
export class ProgramarCitaPage implements OnInit {

  constructor( private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
