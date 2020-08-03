import { Component, OnInit, ViewChild } from '@angular/core';
import { PopoverController, IonSearchbar, ModalController } from '@ionic/angular';
import { PoopcionComponent } from '../components/poopcion/poopcion.component';
import { Observable } from 'rxjs';
import { CitaService } from '../services/cita.service';
import { ProgramarCitaPage } from '../programar-cita/programar-cita.page';

@Component({
  selector: 'app-citas',
  templateUrl: './citas.page.html',
  styleUrls: ['./citas.page.scss'],
})
export class CitasPage implements OnInit {

  results;
  searchTerm = '';

  //SearchBar
  @ViewChild('searchbar') searchbar: IonSearchbar;
  toggled;


  constructor(private popoverCtrl: PopoverController, private citaService: CitaService, private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  //Programar cita (Modal)
  async openModal(){
    const modal = await this.modalCtrl.create({
     component: ProgramarCitaPage,
     componentProps: {
       nombre: 'Prueba',
       pais: 'Ni idea'
     }
   });

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
    else if (data.item == "programar-cita"){
      this.openModal();
    }
  }

  //Search Bar
  showDefaultBar() {
    this.toggled = false;
  }
  searchChanged() {
    this.citaService.search(this.searchTerm).subscribe((result: any) => {
      console.log('details: ', result);
      this.results = result;
    });
  }
}
