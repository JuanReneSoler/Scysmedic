import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ResultadosDetailPageRoutingModule } from './resultados-detail-routing.module';

import { ResultadosDetailPage } from './resultados-detail.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ResultadosDetailPageRoutingModule
  ],
  declarations: [ResultadosDetailPage]
})
export class ResultadosDetailPageModule {}
