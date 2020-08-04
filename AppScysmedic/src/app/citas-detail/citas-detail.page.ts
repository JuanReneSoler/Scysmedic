import { Component, OnInit,Input } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-citas-detail',
  templateUrl: './citas-detail.page.html',
  styleUrls: ['./citas-detail.page.scss'],
})
export class CitasDetailPage implements OnInit {

  @Input() cita;
  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
