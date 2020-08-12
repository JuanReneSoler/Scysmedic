import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { VincularTarjetaPage } from './vincular-tarjeta.page';

const routes: Routes = [
  {
    path: '',
    component: VincularTarjetaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class VincularTarjetaPageRoutingModule {}
