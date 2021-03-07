import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { BuscarLaboratorioPageRoutingModule } from './buscar-laboratorio-routing.module';

import { BuscarLaboratorioPage } from './buscar-laboratorio.page';
import { IonicSelectableModule } from 'ionic-selectable';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    BuscarLaboratorioPageRoutingModule,
    IonicSelectableModule
  ],
  declarations: [BuscarLaboratorioPage]
})
export class BuscarLaboratorioPageModule {}
