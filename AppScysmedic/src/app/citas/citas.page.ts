import { Component, OnInit, ViewChild } from '@angular/core';
import { PopoverController, IonSearchbar, ModalController, IonItemSliding } from '@ionic/angular';
import { PoopcionComponent } from '../components/poopcion/poopcion.component';
import { CitaService } from '../services/cita.service';
import { ProgramarCitaPage } from '../programar-cita/programar-cita.page';
import { CitasDetailPage } from '../citas-detail/citas-detail.page';

@Component({
  selector: 'app-citas',
  templateUrl: './citas.page.html',
  styleUrls: ['./citas.page.scss'],
})
export class CitasPage implements OnInit {

  citas = [
    {
      id: 1,
      fecha: '2020-09-04',
      centro: 'Hospital Princeton-Plainsboro',
      especialista: 'Dr. Gregory House M.D.',
      especialidad: 'Diagnóstico Médico',
      imagen: 'https://3.bp.blogspot.com/_X1iErLcd9gs/SkKWX-_ngxI/AAAAAAAAAy8/RF3qAtxVef4/s280/20070425022321-hugh-laurie.jpg'
    },
    {
      id: 2,
      fecha: '2020-09-07',
      centro: 'Hospital docente Dr. Dario Contreras',
      especialista: 'Dr. Katherine Mejia',
      especialidad: 'Psiquiatra',
      imagen: 'https://image.freepik.com/free-photo/beautiful-young-female-doctor-looking-camera-office_1301-7807.jpg'
    },
    {
      id: 3,
      fecha: '2020-09-15',
      centro: 'Hospital Padre Billini',
      especialista: 'Dr. Pedro Sanchez',
      especialidad: 'Neumologia',
      imagen: 'https://asset.for.myhealthcare.co/uploads/doctors/2019/10/1570509986profile.png'
    }
  ];
  searchTerm = '';

  //SearchBar
  @ViewChild('searchbar') searchbar: IonSearchbar;
  toggled = false;


  constructor(private popoverCtrl: PopoverController, private citaService: CitaService, private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  //Programar cita (Modal)
  async openProgramarCita() {
    const modal = await this.modalCtrl.create({
      component: ProgramarCitaPage,
      componentProps: {
        nombre: 'Prueba',
        pais: 'Ni idea'
      }
    });

    await modal.present();
    const { data } = await modal.onDidDismiss();
    //this.citas.push(data);

  }

  //Obtener detalles de la cita(Modal)
  async openDetallesCita(cita,sliding) {
    const modal = await this.modalCtrl.create({
      component: CitasDetailPage,
      componentProps: {
        cita: cita
      }
    });
    sliding.close();

    await modal.present();


  }


  //PopOver
  async showpop(event) {
    const popover = await this.popoverCtrl.create({
      component: PoopcionComponent,
      event: event
    })

    await popover.present();

    const { data } = await popover.onDidDismiss();

    if (data.item == "buscar") {
      this.toggled = true;
      setTimeout(() => {
        this.searchbar.setFocus();
      }, 5);
    }
    else if (data.item == "programar-cita") {
      this.openProgramarCita();
    }
  }

  //Search Bar
  showDefaultBar() {
    this.toggled = false;
  }

  searchChanged() {
    this.citaService.search(this.searchTerm).subscribe((result: any) => {
      console.log('details: ', result);
      //this.results = result;
    });
  }
}
