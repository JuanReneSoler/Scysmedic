import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { ResultadosDetailPage } from '../resultados-detail/resultados-detail.page';

@Component({
  selector: 'app-resultados',
  templateUrl: './resultados.page.html',
  styleUrls: ['./resultados.page.scss'],
})
export class ResultadosPage implements OnInit {

  recetas = [
    {
      icono: 'document-text-outline',
      tipo_documento: 'Receta',
      fecha: '4 de Julio 2020',
      paciente: 'Juan Arias',
      especialista: 'Dr. Francisco Gomez',
      detalles: [{
        medicamento: 'Metronidazol 1mg',
        cantidad: 20,
        aplicacion: 'Una tableta antes de cada comida'
      }],
      centro: 'Centro médico especializado',
      especialidad: 'Gastroenterologia',
      imagen_especialista: 'https://www.doctortipster.com/wp-content/uploads/2016/02/Dr-Zukerman-Profile.jpg',
      estado: 'Pendiente por comprar'
    },
    {
      icono: 'document-text-outline',
      tipo_documento: 'Receta',
      fecha: '19 de Julio 2020',
      paciente: 'Juan Arias',
      especialista: 'Dr. Xiomara Hernandez',
      detalles: [
        {
          medicamento: 'Bisocor 10mg',
          cantidad: 15,
          aplicacion: 'Media tableta cada 12 horas'
        },
        {
          medicamento: 'Bisocor 10mg',
          cantidad: 15,
          aplicacion: 'Media tableta cada 12 horas'
        }
      ],
      centro: 'La Plaza de la Salud',
      especialidad: 'Cardiología',
      imagen_especialista: 'https://image.freepik.com/free-photo/beautiful-young-female-doctor-looking-camera-office_1301-7807.jpg',
      estado: 'Pendiente por comprar'

    }
  ];
  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }


  //Obtener detalle de resultado
  async openDetallesResultado(resultado) {
    const modal = await this.modalCtrl.create({
      component: ResultadosDetailPage,
      componentProps: {
        resultado: resultado
      }
    });

    await modal.present();
  }

}
