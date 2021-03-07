import { Component, OnInit, Input } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-compra-detail',
  templateUrl: './compra-detail.page.html',
  styleUrls: ['./compra-detail.page.scss'],
})
export class CompraDetailPage implements OnInit {

  @Input() compra;
  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  cerrarSinPasarDatos() {
    this.modalCtrl.dismiss();
  }
  cerrarypasarDatos() {
    this.modalCtrl.dismiss();
  }
}
