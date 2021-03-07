import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { DespachoPageRoutingModule } from './despacho-routing.module';

import { DespachoPage } from './despacho.page';
import { OrdersComponent } from './components/orders/orders.component';
import { TabsComponent } from './components/tabs/tabs.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    DespachoPageRoutingModule
  ],
  declarations: [DespachoPage, OrdersComponent, TabsComponent]
})
export class DespachoPageModule {}
