import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { IonicSelectableComponent } from 'ionic-selectable';

@Component({
  selector: 'app-vincular-seguro-medico',
  templateUrl: './vincular-seguro-medico.page.html',
  styleUrls: ['./vincular-seguro-medico.page.scss'],
})
export class VincularSeguroMedicoPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }

  aseguradora_seleccionada = null;

  aseguradoras = [
    {
      id: 0,
      nombre: 'ARS Salud'
    },
    {
      id: 1,
      nombre: 'SENASA'
    },
    {
      id: 2,
      nombre: 'Palic Salud'
    }
  ];

  seleccionarAseguradora(event: {
    component: IonicSelectableComponent,
    value: any
  }) {
    this.aseguradora_seleccionada = event.value;
  }

  submitForm(){
    
  }
}
