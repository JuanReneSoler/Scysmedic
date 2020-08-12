import { Component, OnInit, ViewChild } from '@angular/core';
import { ModalController, AlertController, IonDatetime } from '@ionic/angular';

@Component({
  selector: 'app-programar-cita',
  templateUrl: './programar-cita.page.html',
  styleUrls: ['./programar-cita.page.scss'],
})
export class ProgramarCitaPage implements OnInit {
  //@ViewChild(IonSegment, {static:true}) segment: IonSegment;
  @ViewChild(IonDatetime,{static:true}) datetime: IonDatetime;

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
      especialidad: '',
      imagen: 'https://www.webconsultas.com/sites/default/files/styles/wc_adaptive_entrevista__small/public/entrevistas/dr-gonzalo-guerra-flecha.jpg'
    },
    {
      id: 1,
      nombre: 'Dra. Maria Montez',
      hospital: '',
      especialidad: '',
      imagen: 'https://i1.wp.com/centrolaser.com.do/wp-content/uploads/2017/07/dra-antonia-paniagua-centro-laser.jpg?w=1080&ssl=1'
    },
    {
      id: 2,
      nombre: 'Dr. Juliana Rengoso',
      hospital: '',
      especialidad: '',
      imagen: 'https://hospiten.com/Portals/0/Images/Professionals/dra-lucia-pimentel-villasmil-dermatologa-hospiten-rambla-santa-cruz-de-tenerife-unidad-de-dermatologia-cosmetica-hospiten-rambla-tenerife.jpg?ver=2019-08-22-082759-893'
    },
    {
      id: 3,
      nombre: 'Dr. Juan Francisco Echevarria',
      hospital: '',
      especialidad: '',
      imagen: 'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRuI8H7tl5xt3IUaU8-CT0Z9Lg64Gay0Bd0vQ&usqp=CAU'
    },
  ];


  fecha = new Date();
  centro_seleccionado = null;
  especialidad_seleccionada = null;
  especialista_seleccionado = null;
  constructor( private modalCtrl: ModalController, public alertController: AlertController) { }

  ngOnInit() {
  }


  async presentAlertConfirm() {
    const alert = await this.alertController.create({
      cssClass: 'my-custom-class',
      header: 'Mensaje',
      message: 'Su solicitud ha sido enviada, en breve el hospital confirmará la solicitud.',
      buttons: [
        {
          text: 'Ok',
          handler: () => {
            this.cerrarSinPasarDatos();
          }
        }
      ]
    });

    await alert.present();

  }

  cambiarFecha(){
    this.datetime.value= new Date(2020, 7, 15).toString();
  }
  
  cerrarSinPasarDatos(){
    this.modalCtrl.dismiss();
  }
  cerrarYPasarDatos(){
    var cita = {  centro: this.centro_seleccionado.nombre, especialidad: this.especialidad_seleccionada.nombre , fecha: this.fecha, especialista: this.especialista_seleccionado.nombre, imagen:'https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRuI8H7tl5xt3IUaU8-CT0Z9Lg64Gay0Bd0vQ&usqp=CAU' }
    this.modalCtrl.dismiss(cita);
  }
}
