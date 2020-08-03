import { NgModule } from '@angular/core';
import {Routes, RouterModule} from "@angular/router";
import { CommonModule } from '@angular/common';
import { IonicModule } from '@ionic/angular';
import { FormsModule } from '@angular/forms';
import { HomePage } from './home.page';

const routes: Routes = [
  {
    path: 'home',
    component: HomePage,
    children: [
      {
        path:'citas',
        loadChildren: '../citas/citas.module#CitasPageModule'
      },
      {
        path:'compras',
        loadChildren: '../compras/compras.module#ComprasPageModule'
      },
      {
        path:'resultados',
        loadChildren: '../resultados/resultados.module#ResultadosPageModule'
      }
    ]
  },
  {
    path: '',
    redirectTo: '/home/citas',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes)
  ],
  declarations: [HomePage]
})
export class HomePageModule {}
