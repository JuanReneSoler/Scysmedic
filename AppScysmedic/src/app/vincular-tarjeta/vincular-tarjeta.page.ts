import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-vincular-tarjeta',
  templateUrl: './vincular-tarjeta.page.html',
  styleUrls: ['./vincular-tarjeta.page.scss'],
})
export class VincularTarjetaPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }

  
  submitForm(){
    
  }
}
