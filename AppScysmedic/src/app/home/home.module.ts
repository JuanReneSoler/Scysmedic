import { NgModule } from '@angular/core';
import {Routes, RouterModule} from "@angular/router";
import { CommonModule } from '@angular/common';
import { IonicModule } from '@ionic/angular';
import { FormsModule } from '@angular/forms';
import { HomePage } from './home.page';

const routes: Routes = [
  {
    path: '',
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
