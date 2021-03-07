import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ConfigAparienciaPageRoutingModule } from './config-apariencia-routing.module';

import { ConfigAparienciaPage } from './config-apariencia.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ConfigAparienciaPageRoutingModule
  ],
  declarations: [ConfigAparienciaPage]
})
export class ConfigAparienciaPageModule {}
