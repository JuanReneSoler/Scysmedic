import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ResultadosDetailPageRoutingModule } from './resultados-detail-routing.module';

import { ResultadosDetailPage } from './resultados-detail.page';
import { BuscarLaboratorioPageModule } from '../buscar-laboratorio/buscar-laboratorio.module';
import { BuscarLaboratorioPage } from '../buscar-laboratorio/buscar-laboratorio.page';
import { IonicSelectableModule } from 'ionic-selectable';

@NgModule({
  entryComponents: [
    BuscarLaboratorioPage
  ],
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ResultadosDetailPageRoutingModule,
    BuscarLaboratorioPageModule,
    IonicSelectableModule
  ],
  declarations: [ResultadosDetailPage]
})
export class ResultadosDetailPageModule {}
