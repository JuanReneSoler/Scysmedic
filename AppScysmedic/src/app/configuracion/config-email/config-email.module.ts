import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ConfigEmailPageRoutingModule } from './config-email-routing.module';

import { ConfigEmailPage } from './config-email.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ConfigEmailPageRoutingModule
  ],
  declarations: [ConfigEmailPage]
})
export class ConfigEmailPageModule {}
