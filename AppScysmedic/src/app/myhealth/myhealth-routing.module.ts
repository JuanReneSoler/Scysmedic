import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MyhealthPage } from './myhealth.page';

const routes: Routes = [
  {
    path: '',
    component: MyhealthPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MyhealthPageRoutingModule {}
