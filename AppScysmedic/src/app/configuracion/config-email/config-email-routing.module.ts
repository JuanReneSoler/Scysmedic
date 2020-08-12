import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConfigEmailPage } from './config-email.page';

const routes: Routes = [
  {
    path: '',
    component: ConfigEmailPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConfigEmailPageRoutingModule {}
