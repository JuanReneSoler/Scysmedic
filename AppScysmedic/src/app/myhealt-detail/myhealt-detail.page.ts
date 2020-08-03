import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-myhealt-detail',
  templateUrl: './myhealt-detail.page.html',
  styleUrls: ['./myhealt-detail.page.scss'],
})
export class MyhealtDetailPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
