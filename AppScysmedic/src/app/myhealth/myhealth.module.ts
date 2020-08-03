import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { MyhealthPageRoutingModule } from './myhealth-routing.module';
import { MyhealthPage } from './myhealth.page';
import { MyhealtDetailPage } from '../myhealt-detail/myhealt-detail.page';
import { MyhealtDetailPageModule } from '../myhealt-detail/myhealt-detail.module';

@NgModule({
  entryComponents :[
    MyhealtDetailPage
  ],
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    MyhealthPageRoutingModule,
    MyhealtDetailPageModule
  ],
  declarations: [MyhealthPage]
})
export class MyhealthPageModule {}
