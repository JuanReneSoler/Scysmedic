import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ResultadosPageRoutingModule } from './resultados-routing.module';

import { ResultadosPage } from './resultados.page';
import { ResultadosDetailPageModule } from '../resultados-detail/resultados-detail.module';
import { ResultadosDetailPage } from '../resultados-detail/resultados-detail.page';

@NgModule({
  entryComponents: [
    ResultadosDetailPage
  ],
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ResultadosPageRoutingModule,
    ResultadosDetailPageModule
  ],
  declarations: [ResultadosPage]
})
export class ResultadosPageModule {}
