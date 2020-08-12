import { Component, OnInit, Input } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { VincularSeguroMedicoPage } from 'src/app/vincular-seguro-medico/vincular-seguro-medico.page';

@Component({
  selector: 'app-config-aseguradora',
  templateUrl: './config-aseguradora.page.html',
  styleUrls: ['./config-aseguradora.page.scss'],
})
export class ConfigAseguradoraPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  @Input() usuario;

  ngOnInit() {
  }
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }

  async openModalVincularSeguro() {
    const modal = await this.modalCtrl.create({
      component: VincularSeguroMedicoPage,
      componentProps: {
        usuario: this.usuario
      }
    });

    await modal.present();
  }
}
