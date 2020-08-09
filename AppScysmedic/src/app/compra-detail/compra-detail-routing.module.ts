import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CompraDetailPage } from './compra-detail.page';

const routes: Routes = [
  {
    path: '',
    component: CompraDetailPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CompraDetailPageRoutingModule {}
