import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CitasDetailPage } from './citas-detail.page';

const routes: Routes = [
  {
    path: '',
    component: CitasDetailPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CitasDetailPageRoutingModule {}
