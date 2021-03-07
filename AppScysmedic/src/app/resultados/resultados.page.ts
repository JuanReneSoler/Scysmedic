import { Component, OnInit, ViewChild } from '@angular/core';
import { ModalController, IonSegment } from '@ionic/angular';
import { ResultadosDetailPage } from '../resultados-detail/resultados-detail.page';

@Component({
  selector: 'app-resultados',
  templateUrl: './resultados.page.html',
  styleUrls: ['./resultados.page.scss'],
})
export class ResultadosPage implements OnInit {

  @ViewChild(IonSegment, {static:true}) segment: IonSegment;

  recetas = [
    {
      icono: 'document-text-outline',
      tipo_documento: 'Receta',
      fecha: '4 de Julio 2020',
      paciente: 'Sheldon Cooper',
      especialista: 'Dr. Francisco Gomez',
      detalles: [{
        medicamento: 'Metronidazol 1mg',
        cantidad: 20,
        aplicacion: 'Una tableta antes de cada comida'
      }],
      centro: 'Centro médico especializado',
      especialidad: 'Gastroenterologia',
      imagen_especialista: 'https://www.doctortipster.com/wp-content/uploads/2016/02/Dr-Zukerman-Profile.jpg',
      estado: 'Pendiente por comprar',
      color_estado: 'danger',
      tipo_entidad: 'Farmacia',
      icono_estado: 'time-outline'

    },
    {
      icono: 'document-text-outline',
      tipo_documento: 'Receta',
      fecha: '19 de Julio 2020',
      paciente: 'Sheldon Cooper',
      especialista: 'Dr. Xiomara Hernandez',
      detalles: [
        {
          medicamento: 'Bisocor 10mg',
          cantidad: 15,
          aplicacion: 'Media tableta cada 12 horas'
        },
        {
          medicamento: 'Omeprazol  40mg',
          cantidad: 5,
          aplicacion: '1 tableta al día'
        }
      ],
      centro: 'La Plaza de la Salud',
      especialidad: 'Cardiología',
      imagen_especialista: 'https://image.freepik.com/free-photo/beautiful-young-female-doctor-looking-camera-office_1301-7807.jpg',
      estado: 'Pendiente por comprar',
      color_estado: 'danger',
      tipo_entidad: 'Farmacia',
      icono_estado: 'time-outline'
    }
  ];

  indicaciones = [
    {
      icono: 'flask-outline',
      tipo_documento: 'Indicacion',
      fecha_cita: '2 de Agosto 2020',
      especialista: 'Dr. Amadis Suarez',
      centro_medico: 'Clínica Abreu',
      paciente: 'Sheldon Cooper',
      descripcion: 'Hemograma completo',
      comentarios: 'No es necesario hacerlo en ayunas',
      laboratorio: '',
      laboratorio_direccion: '',
      laboratorio_telefono: '',
      fecha_realizacion: '',
      total_inicial: 0,
      monto_descontado_aseguradora: 0,
      monto_final: 0,
      estado: 'Pendiente',
      color_estado: 'danger',
      icono_estado: 'time-outline',
      documento: {
        formato: null,
        peso: null,
        fecha: null
      },
      tipo_entidad: 'Laboratorio'
    },
    {
      icono: 'flask-outline',
      tipo_documento: 'Indicacion',
      fecha_cita: '2 de Agosto 2020',
      especialista: 'Dr. Amadis Suarez',
      centro_medico: 'Clínica Abreu',
      paciente: 'Sheldon Cooper',
      descripcion: 'Perfil Tiroideo',
      comentarios: '',
      laboratorio: 'Laboratorio Amadita',
      laboratorio_direccion: 'v. Sabana Larga, esq. Calle José Cabrera, Plaza Ozama. Ens. Ozama. Santo Domingo, R.D.',
      laboratorio_telefono: '809-794-6797',
      fecha_realizacion: '3 de Agosto 2020',
      total_inicial: 700,
      monto_descontado_aseguradora: 413.2,
      monto_final: 286.8,
      estado: 'Por realizar (Pagado)',
      color_estado: 'danger',
      icono_estado: 'time-outline',
      documento: {
        formato: null,
        peso: null,
        fecha: null
      },
      tipo_entidad: 'Laboratorio'

    },
    {
      icono: 'flask-outline',
      tipo_documento: 'Indicacion',
      fecha_cita: '4 de Julio 2020',
      especialista: 'Dr. Amadis Suarez',
      centro_medico: 'Clínica Abreu',
      paciente: 'Sheldon Cooper',
      descripcion: 'Perfil Lipídico',
      comentarios: '',
      laboratorio: 'Laboratorio Amadita',
      laboratorio_direccion: 'v. Sabana Larga, esq. Calle José Cabrera, Plaza Ozama. Ens. Ozama. Santo Domingo, R.D.',
      laboratorio_telefono: '809-794-6797',
      fecha_realizacion: '6 de Julio 2020',
      total_inicial: 1200,
      monto_descontado_aseguradora: 450,
      monto_final: 850,
      estado: 'Realizado (En espera de resultados)',
      color_estado: 'warning',
      icono_estado: 'time-outline',
      documento: {
        formato: null,
        peso: null,
        fecha: null
      },
      tipo_entidad: 'Laboratorio'
    }
  ];

  segmento = '';

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
    this.segment.value = 'recetas';
    this.segmento = this.segment.value;
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

  segmentChanged( event ){
    const valorSegemento = event.detail.value;
    this.segmento = valorSegemento;
  }

  search_bar_visible = false;
  datetime_picker_visible = false;
  opcion_busqueda = '';


  OptionSelected( event ){
    this.opcion_busqueda = event.detail.value;
    if(this.opcion_busqueda == 'institucion'){
      this.search_bar_visible = true;
      this.datetime_picker_visible = false;
    }
    else{
      this.search_bar_visible = false;
      this.datetime_picker_visible = true;

    }
  }

}
