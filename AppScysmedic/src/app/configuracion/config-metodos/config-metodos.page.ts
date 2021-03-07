import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { VincularTarjetaPage } from 'src/app/vincular-tarjeta/vincular-tarjeta.page';

@Component({
  selector: 'app-config-metodos',
  templateUrl: './config-metodos.page.html',
  styleUrls: ['./config-metodos.page.scss'],
})
export class ConfigMetodosPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  tarjetas = [
    {
      compania: 'VISA',
      nro: '**** 9431',
      fecha_expiracion: '07/23',
      cvc: '775'
    },
    {
      compania: 'Master Card',
      nro: '**** 1579',
      fecha_expiracion: '05/22',
      cvc: '674'
    }
  ];

  
  ngOnInit() {
  }
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }

  async openModalVincularSeguro() {
    const modal = await this.modalCtrl.create({
      component: VincularTarjetaPage,
      componentProps: {
      }
    });

    await modal.present();
  }
}
