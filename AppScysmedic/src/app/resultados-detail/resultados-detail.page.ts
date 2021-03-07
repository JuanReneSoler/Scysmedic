import { Component, OnInit,Input } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { BuscarLaboratorioPage } from '../buscar-laboratorio/buscar-laboratorio.page';

@Component({
  selector: 'app-resultados-detail',
  templateUrl: './resultados-detail.page.html',
  styleUrls: ['./resultados-detail.page.scss'],
})
export class ResultadosDetailPage implements OnInit {

  @Input() resultado;

  

  constructor(private modalCtrl:ModalController) { }

  ngOnInit() {
  }

  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }

  //Buscar la entidad 
  async openBusquedaEntidad(resultado) {
    const modal = await this.modalCtrl.create({
      component: BuscarLaboratorioPage,
      componentProps: {
        resultado: resultado
      }
    });
    
    await modal.present();
    
    const  {data}  = await modal.onDidDismiss();
    resultado.estado = data.nuevo_estado;
    resultado.color_estado = data.nuevo_color;
  }
}
