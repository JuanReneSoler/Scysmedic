import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ConfiguracionPage } from './configuracion.page';

const routes: Routes = [
  {
    path: '',
    component: ConfiguracionPage
  },
  {
    path: 'info-perfil',
    loadChildren: () => import('./info-perfil/info-perfil.module').then( m => m.InfoPerfilPageModule)
  },
  {
    path: 'config-email',
    loadChildren: () => import('./config-email/config-email.module').then( m => m.ConfigEmailPageModule)
  },
  {
    path: 'config-aseguradora',
    loadChildren: () => import('./config-aseguradora/config-aseguradora.module').then( m => m.ConfigAseguradoraPageModule)
  },
  {
    path: 'config-metodos',
    loadChildren: () => import('./config-metodos/config-metodos.module').then( m => m.ConfigMetodosPageModule)
  },
  {
    path: 'config-apariencia',
    loadChildren: () => import('./config-apariencia/config-apariencia.module').then( m => m.ConfigAparienciaPageModule)
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ConfiguracionPageRoutingModule {}
