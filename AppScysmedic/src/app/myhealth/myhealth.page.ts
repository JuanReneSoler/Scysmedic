import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { MyhealtDetailPage } from '../myhealt-detail/myhealt-detail.page';
import { ValueAccessor } from '@ionic/angular/directives/control-value-accessors/value-accessor';

@Component({
  selector: 'app-myhealth',
  templateUrl: './myhealth.page.html',
  styleUrls: ['./myhealth.page.scss'],
})
export class MyhealthPage implements OnInit {

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  async openModal(){
     const modal = await this.modalCtrl.create({
      component: MyhealtDetailPage,
      componentProps: {
        nombre: 'Prueba',
        pais: 'Ni idea'
      }
    });

    await modal.present();
  }
}
