import { Component, OnInit, Input } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-config-email',
  templateUrl: './config-email.page.html',
  styleUrls: ['./config-email.page.scss'],
})
export class ConfigEmailPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  @Input() usuario;
  ngOnInit() {
  }
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
