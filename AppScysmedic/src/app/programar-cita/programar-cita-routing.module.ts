import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ProgramarCitaPage } from './programar-cita.page';

const routes: Routes = [
  {
    path: '',
    component: ProgramarCitaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ProgramarCitaPageRoutingModule {}
