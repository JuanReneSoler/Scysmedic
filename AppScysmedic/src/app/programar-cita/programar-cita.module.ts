import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ProgramarCitaPageRoutingModule } from './programar-cita-routing.module';

import { ProgramarCitaPage } from './programar-cita.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ProgramarCitaPageRoutingModule
  ],
  declarations: [ProgramarCitaPage]
})
export class ProgramarCitaPageModule {}
