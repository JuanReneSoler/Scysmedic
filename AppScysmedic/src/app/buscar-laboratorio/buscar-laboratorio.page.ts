import { Component, OnInit, Input } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { IonicSelectableComponent } from 'ionic-selectable';

@Component({
  selector: 'app-buscar-laboratorio',
  templateUrl: './buscar-laboratorio.page.html',
  styleUrls: ['./buscar-laboratorio.page.scss'],
})
export class BuscarLaboratorioPage implements OnInit {

  @Input() resultado;
  seleccionado ;
  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }
  cerrarypasarDatos() {
    this.modalCtrl.dismiss({ nuevo_estado: 'Cotización solicitada', nuevo_color: 'warning' });

  }
  cerrarSinPasarDatos() {
    this.modalCtrl.dismiss();
  }

  laboratorio_seleccionado = null;
  farmacia_seleccionada = null;
  seguro_medico = null;


  laboratorios = [
    {
      id: 0,
      nombre: 'Laboratorio Amadita',
      direccion: 'Av. Sabana Larga, esq. Calle José Cabrera, Plaza Ozama. Ens. Ozama. Santo Domingo, R.D. Club Rotario',
      ciudad: 'Santo Domingo'
    },
    {
      id: 1,
      nombre: 'Laboratorio Referencia',
      direccion: 'Av. Sabana Larga No. 73 esq. Costa Rica, Ens. Ozama, Santo Domingo.',
      ciudad: 'Santo Domingo'
    },
    {
      id: 2,
      nombre: 'Laboratorio Patria Rivas',
      direccion: 'Calle Lea de Castro Esq. José Joaquin. Pérez, Gazcue',
      ciudad: 'Santo Domingo'
    }
  ];

  farmacias = [
    {
      id: 0,
      nombre: 'Farmacia Europa',
      direccion: 'Av. Venezuela esq Club de Leones, Ensanche Ozama',
      ciudad: 'Santo Domingo'
    },
    {
      id: 1,
      nombre: 'Farmacia Tony',
      direccion: 'Av. Sabana Larga  esq. Club de Leones, Ensanche Ozama',
      ciudad: 'Santo Domingo'
    },
    {
      id: 2,
      nombre: 'Farmacia Carol - Arroyo Hondo',
      direccion: 'esq. Calle Camino Chiquito & Calle Doctores Mallen',
      ciudad: 'Santo Domingo'
    }
  ];

  seleccionarLaboratorio(event: {
    component: IonicSelectableComponent,
    value: any
  }) {
    this.laboratorio_seleccionado = event.value;
  }
  seleccionarFarmacia(event: {
    component: IonicSelectableComponent,
    value: any
  }) {
    this.farmacia_seleccionada = event.value;
  }
}
