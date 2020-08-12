import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { InfoPerfilPage } from './info-perfil/info-perfil.page';
import { ConfigEmailPage } from './config-email/config-email.page';
import { ConfigAseguradoraPage } from './config-aseguradora/config-aseguradora.page';
import { ConfigMetodosPage } from './config-metodos/config-metodos.page';
import { ConfigAparienciaPage } from './config-apariencia/config-apariencia.page';

@Component({
  selector: 'app-configuracion',
  templateUrl: './configuracion.page.html',
  styleUrls: ['./configuracion.page.scss'],
})
export class ConfiguracionPage implements OnInit {
  
  darkMode: boolean = true;

  constructor(private modalCtrl: ModalController) { 
    const prefersDark = window.matchMedia('(prefers-color-scheme: dark)');
    this.darkMode = prefersDark.matches;
  }

  //puedes usar esta variable para pasar los datos a los modales

  usuario = {
    nombre: 'Sheldon Cooper',
    telefono: '8095973163',
    contrasena: '5fglfdl5rew',
    email: 'SheldonCopper@ionic.com',
    datos_aseguradora: {
      aseguradora_nombre: 'ARS Salud',
      nss: '',
      plan: 'Plan básico',
    }
  };

  ngOnInit() {
  }

  async openModalInfoPerfil() {
    const modal = await this.modalCtrl.create({
      component: InfoPerfilPage,
      componentProps: {
        usuario: this.usuario
      }
    });

    await modal.present();
  }

  async openModalEmail() {
    const modal = await this.modalCtrl.create({
      component: ConfigEmailPage,
      componentProps: {
        usuario: this.usuario
      }
    });

    await modal.present();
  }

  async openModalAseguradora() {
    const modal = await this.modalCtrl.create({
      component: ConfigAseguradoraPage,
      componentProps: {
        usuario: this.usuario

      }
    });

    await modal.present();
  }

  async openModalMetodos() {
    const modal = await this.modalCtrl.create({
      component: ConfigMetodosPage,
      componentProps: {
        usuario: this.usuario

      }
    });

    await modal.present();
  }

  async openModalApariencia() {
    const modal = await this.modalCtrl.create({
      component: ConfigAparienciaPage,
      componentProps: {
        usuario: this.usuario

      }
    });

    await modal.present();
  }


  //Dark mode on-off


  toggleDarkMode() {
    console.log(window.matchMedia('(prefers-color-scheme: dark)'));
    this.darkMode = !this.darkMode;
    document.body.classList.toggle( 'dark' );
  }
}
