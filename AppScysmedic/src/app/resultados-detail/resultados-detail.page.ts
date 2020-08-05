import { Component, OnInit,Input } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-resultados-detail',
  templateUrl: './resultados-detail.page.html',
  styleUrls: ['./resultados-detail.page.scss'],
})
export class ResultadosDetailPage implements OnInit {

  @Input() resultado;

  

  constructor(private modalCtrl:ModalController) { }

  ngOnInit() {
  }

  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
