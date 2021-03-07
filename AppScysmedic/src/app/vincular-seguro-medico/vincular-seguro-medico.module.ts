import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { VincularSeguroMedicoPageRoutingModule } from './vincular-seguro-medico-routing.module';

import { VincularSeguroMedicoPage } from './vincular-seguro-medico.page';
import { IonicSelectableModule } from 'ionic-selectable';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    VincularSeguroMedicoPageRoutingModule,
    IonicSelectableModule
  ],
  declarations: [VincularSeguroMedicoPage]
})
export class VincularSeguroMedicoPageModule {}
