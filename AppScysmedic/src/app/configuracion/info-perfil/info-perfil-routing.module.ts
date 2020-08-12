import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InfoPerfilPage } from './info-perfil.page';

const routes: Routes = [
  {
    path: '',
    component: InfoPerfilPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class InfoPerfilPageRoutingModule {}
