import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { MyhealtDetailPageRoutingModule } from './myhealt-detail-routing.module';

import { MyhealtDetailPage } from './myhealt-detail.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MyhealtDetailPageRoutingModule
  ],
  declarations: [MyhealtDetailPage]
})
export class MyhealtDetailPageModule {}
