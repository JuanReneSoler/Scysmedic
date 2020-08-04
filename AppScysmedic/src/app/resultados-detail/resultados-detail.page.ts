import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-resultados-detail',
  templateUrl: './resultados-detail.page.html',
  styleUrls: ['./resultados-detail.page.scss'],
})
export class ResultadosDetailPage implements OnInit {

  constructor(private modalCtrl:ModalController) { }

  ngOnInit() {
  }

  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
