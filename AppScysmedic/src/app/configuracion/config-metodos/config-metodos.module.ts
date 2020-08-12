import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ConfigMetodosPageRoutingModule } from './config-metodos-routing.module';

import { ConfigMetodosPage } from './config-metodos.page';
import { VincularTarjetaPageModule } from 'src/app/vincular-tarjeta/vincular-tarjeta.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ConfigMetodosPageRoutingModule,
    VincularTarjetaPageModule
  ],
  declarations: [ConfigMetodosPage]
})
export class ConfigMetodosPageModule {}
