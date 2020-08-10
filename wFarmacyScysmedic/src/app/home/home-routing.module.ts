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
        loadChildren: () => import('./pages/despacho/despacho.module').then( m => m.DespachoPageModule)
      },
      {
        path: 'entrada',
        loadChildren: () => import('./pages/entrada/entrada.module').then( m => m.EntradaPageModule)
      },
      {
        path:"configuration",
        loadChildren:()=>import("./pages/configuration/configuration.module").then(x=>x.ConfigurationPageModule)
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule {}
