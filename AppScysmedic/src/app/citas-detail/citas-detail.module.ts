import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CitasDetailPageRoutingModule } from './citas-detail-routing.module';

import { CitasDetailPage } from './citas-detail.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    CitasDetailPageRoutingModule
  ],
  declarations: [CitasDetailPage]
})
export class CitasDetailPageModule {}
