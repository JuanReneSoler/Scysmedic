import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConfigAparienciaPage } from './config-apariencia.page';

const routes: Routes = [
  {
    path: '',
    component: ConfigAparienciaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConfigAparienciaPageRoutingModule {}
