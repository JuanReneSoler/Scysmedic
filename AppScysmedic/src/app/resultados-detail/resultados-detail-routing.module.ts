import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ResultadosDetailPage } from './resultados-detail.page';

const routes: Routes = [
  {
    path: '',
    component: ResultadosDetailPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ResultadosDetailPageRoutingModule {}
