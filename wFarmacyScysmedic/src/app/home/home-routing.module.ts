import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePage } from './home.page';

const routes: Routes = [
  {
    path: '',
    component: HomePage,
    children:[
      {
        path: 'despacho',
        loadChildren: () => import('./components/despacho/despacho.module').then( m => m.DespachoPageModule)
      },
      {
        path: 'entrada',
        loadChildren: () => import('./components/entrada/entrada.module').then( m => m.EntradaPageModule)
      }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule {}
