import { Component, OnInit, ViewChild } from '@angular/core';
import { ModalController, IonSegment } from '@ionic/angular';
import { MyhealtDetailPage } from '../myhealt-detail/myhealt-detail.page';
import { ValueAccessor } from '@ionic/angular/directives/control-value-accessors/value-accessor';

@Component({
  selector: 'app-myhealth',
  templateUrl: './myhealth.page.html',
  styleUrls: ['./myhealth.page.scss'],
})
export class MyhealthPage implements OnInit {

  @ViewChild(IonSegment, {static:true}) segment: IonSegment;

  mis_entidades= [
    {
      tipo_entidad: 'Hospital',
      nombre: 'Hospital general Plaza de la Salud',
      direccion: 'Calle Lorem Ipsum #142',
      attached: 'Atached',
      icono_attached: 'attach-outline',
      icono_entidad: 'fitness-outline',
      imagen: 'https://globalhealthintelligence.com/wp-content/uploads/2018/11/dominicana_hospital_general_plaza_de_la_salud_01.jpg',

    },
    {
      tipo_entidad: 'Laboratorio',
      nombre: 'Laboratorio Amadita',
      direccion: 'Calle Lorem Ipsum #53',
      attached: 'Atached',
      icono_attached: 'attach-outline',
      icono_entidad: 'flask-outline',
      imagen: 'https://medii.net/wp-content/uploads/2019/09/amadita-03.jpg',

    }
  ];

  entidades= [
    {
      tipo_entidad: 'Hospital',
      nombre: 'Hospital general Plaza de la Salud',
      direccion: 'Calle Lorem Ipsum #142',
      attached: 'Atached',
      icono_attached: 'attach-outline',
      icono_entidad: 'fitness-outline',
      imagen: 'https://globalhealthintelligence.com/wp-content/uploads/2018/11/dominicana_hospital_general_plaza_de_la_salud_01.jpg',
      telefono: '809-546-4561'

    },
    {
      tipo_entidad: 'Hospital',
      nombre: 'Clinica de Mayo',
      direccion: 'Calle Lorem Ipsum #197',
      attached: 'Atached',
      icono_attached: '',
      icono_entidad: 'fitness-outline',
      imagen: '',
      telefono: '809-546-4561'

    },
    {
      tipo_entidad: 'Laboratorio',
      nombre: 'Laboratorio Amadita',
      direccion: 'Calle Lorem Ipsum #53',
      attached: 'Atached',
      icono_attached: 'attach-outline',
      icono_entidad: 'flask-outline',
      imagen: 'https://medii.net/wp-content/uploads/2019/09/amadita-03.jpg',
      telefono: '829-576-7864'

    },
    {
      tipo_entidad: 'Farmacia',
      nombre: 'Farmacia Salut',
      direccion: 'Calle Lorem Ipsum #54',
      attached: 'No attached',
      icono_attached: '',
      icono_entidad: 'medkit-outline',
      imagen: '',
      telefono:'809-037-4348'

    },
    {
      tipo_entidad: 'Farmacia',
      nombre: 'Farmacia Carol',
      direccion: 'Calle Lorem Ipsum #597',
      attached: 'No attached',
      icono_attached: '',
      icono_entidad: 'medkit-outline',
      imagen: '',
      telefono: '849-137-8446'

    },
    {
      tipo_entidad: 'Farmacia',
      nombre: 'Farmacia Europa',
      direccion: 'Calle Lorem Ipsum #897',
      attached: 'No attached',
      icono_attached: '',
      icono_entidad: 'medkit-outline',
      imagen: '',
      telefono: '809-126-7894'
    },
    {
      tipo_entidad: 'Laboratorio',
      nombre: 'Laboratorio Epsilum',
      direccion: 'Calle Lorem Ipsum #567',
      attached: 'No attached',
      icono_attached: '',
      icono_entidad: 'flask-outline',
      imagen: '',
      telefono: '829-456-7893'
    }
  ];


  filterEntidades(entidades) : any[]{
    return entidades.filter(i => i.tipo_entidad === this.segmento2);
  }


  constructor(private modalCtrl: ModalController) { }
  segmento = '';
  segmento2 ='';

  ngOnInit() {
    this.segment.value = 'mis_entidades';
    this.segmento = this.segment.value;
    this.segmento2 = 'Hospital';
  }

  async openModal() {
    const modal = await this.modalCtrl.create({
      component: MyhealtDetailPage,
      componentProps: {
        nombre: 'Prueba',
        pais: 'Ni idea'
      }
    });

    await modal.present();
  }

  
  segmentChanged( event ){
    const valorSegmento = event.detail.value;
    this.segmento = valorSegmento;
  }
  segmentChanged2( event ){
    const valorSegmento = event.detail.value;
    this.segmento2 = valorSegmento;
    this.filterEntidades(this.entidades);
  }
  

  selectTab( event ){
    console.log(event);
  }



}
