import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';

@Component({
  selector: 'app-programar-cita',
  templateUrl: './programar-cita.page.html',
  styleUrls: ['./programar-cita.page.scss'],
})
export class ProgramarCitaPage implements OnInit {

  centros = [
    {
      id: 0,
      nombre: 'Hospital traumatológico Dr. Darío Contreras',
      direccion: 'Calle Club Rotario',
      ciudad: 'Santo Domingo'
    },
    {
      id: 1,
      nombre: 'Hospital Padre Billini',
      direccion: 'Av Alma Mater',
      ciudad: 'Santo Domingo'
    },
    {
      id: 2,
      nombre: 'Hospital Docente Dr. Francisco E. Moscoso Puello',
      direccion: 'Av Nicolás de Ovando',
      ciudad: 'Santo Domingo'
    }
  ];

  especialidades = [
    {
      id: 0,
      nombre: 'Gastroenterología',
      hospital: '',
    },
    {
      id: 1,
      nombre: 'Cardiología',
      hospital: '',
    },
    {
      id: 2,
      nombre: 'Nefrología',
      hospital: '',
    },
    {
      id: 3,
      nombre: 'Dermatología',
      hospital: '',
    },
  ];

  especialistas = [
    {
      id: 0,
      nombre: 'Dr. Juan Santiago',
      hospital: '',
      especialidad: ''
    },
    {
      id: 1,
      nombre: 'Dra. Maria Montez',
      hospital: '',
      especialidad: ''
    },
    {
      id: 2,
      nombre: 'Dr. Juliana Rengoso',
      hospital: '',
      especialidad: ''
    },
    {
      id: 3,
      nombre: 'Dr. Juan Francisco Echevarria',
      hospital: '',
      especialidad: ''
    },
  ];

  centro_seleccionado = null;
  especialidad_seleccionada = null;
  especialista_seleccionado = null;
  constructor( private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
}
