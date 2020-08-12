import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CompraDetailPageRoutingModule } from './compra-detail-routing.module';

import { CompraDetailPage } from './compra-detail.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CompraDetailPageRoutingModule
  ],
  declarations: [CompraDetailPage]
})
export class CompraDetailPageModule {}
