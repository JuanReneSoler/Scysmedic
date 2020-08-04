import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { ResultadosDetailPage } from '../resultados-detail/resultados-detail.page';

@Component({
  selector: 'app-resultados',
  templateUrl: './resultados.page.html',
  styleUrls: ['./resultados.page.scss'],
})
export class ResultadosPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }


  //Obtener detalle de resultado
  async openDetallesResultado() {
    const modal = await this.modalCtrl.create({
      component: ResultadosDetailPage,
      componentProps: {
        resultado: 'resultado'
      }
    });

    await modal.present();
  }

}
