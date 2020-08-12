import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { VincularTarjetaPageRoutingModule } from './vincular-tarjeta-routing.module';

import { VincularTarjetaPage } from './vincular-tarjeta.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    VincularTarjetaPageRoutingModule
  ],
  declarations: [VincularTarjetaPage]
})
export class VincularTarjetaPageModule {}
