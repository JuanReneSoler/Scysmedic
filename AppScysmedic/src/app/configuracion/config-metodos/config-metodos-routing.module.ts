import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConfigMetodosPage } from './config-metodos.page';

const routes: Routes = [
  {
    path: '',
    component: ConfigMetodosPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConfigMetodosPageRoutingModule {}
