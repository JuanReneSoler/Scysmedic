import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ConfigAseguradoraPageRoutingModule } from './config-aseguradora-routing.module';

import { ConfigAseguradoraPage } from './config-aseguradora.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ConfigAseguradoraPageRoutingModule
  ],
  declarations: [ConfigAseguradoraPage]
})
export class ConfigAseguradoraPageModule {}
