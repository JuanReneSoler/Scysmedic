import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { VincularSeguroMedicoPage } from './vincular-seguro-medico.page';

const routes: Routes = [
  {
    path: '',
    component: VincularSeguroMedicoPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class VincularSeguroMedicoPageRoutingModule {}
