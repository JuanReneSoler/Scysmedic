import { Component, OnInit, Input } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-info-perfil',
  templateUrl: './info-perfil.page.html',
  styleUrls: ['./info-perfil.page.scss'],
})
export class InfoPerfilPage implements OnInit {

  @Input() usuario;

  
  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  editarNombre = true;

  enableNombre(){
    this.editarNombre = false;
  }

  
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
