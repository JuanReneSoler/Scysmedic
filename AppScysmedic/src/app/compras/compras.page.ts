import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { CitasDetailPage } from '../citas-detail/citas-detail.page';
import { CompraDetailPage } from '../compra-detail/compra-detail.page';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.page.html',
  styleUrls: ['./compras.page.scss'],
})
export class ComprasPage implements OnInit {

  compras = [
    {
      id: 1,
      user_id: 1,
      farmacia_id: 1,
      farmacia: 'Farmacia Carol',
      receta_id: 1,
      fecha_compra: '02 Julio 2020',
      codigo_verificacion: 95738553,
      precioPagar: 250,
      monto_cubierto: 86,
      tipo_pago: 'Efectivo',
      estado: 'Pagada y recibida',
      color_estado_secundario: 'success',
      color_estado: 'success',
      icono_estado: 'checkmark-outline',
      cajero: 'Marina de los Santos',
      detalles: [
        {
          medicamento_id: 2,
          descripcion: 'Acetaminofén 10 mg',
          cantidad: 10,
          precio: 20.00,
          impuesto: 0,
          total: 200.00
        },
        {
          medicamento_id: 4,
          descripcion: 'Aspirina 5mg',
          cantidad: 15,
          precio: 10.00,
          impuesto: 0,
          total: 150.00
        }
      ]
    },
    {
      id: 2,
      user_id: 1,
      farmacia_id: 2,
      farmacia: 'Farmacia Europa',
      receta_id: 1,
      fecha_compra: '05 Julio 2020',
      codigo_verificacion: 54217954,
      precioPagar: 2625.00,
      monto_cubierto: 243,
      tipo_pago: 'Efectivo',
      estado: 'Pendiente de pago',
      color_estado_secundario: 'warning',
      color_estado: 'warning',
      icono_estado: 'time-outline',
      cajero: 'Marina de los Santos',
      detalles: [
        {
          medicamento_id: 2,
          descripcion: 'Diazepan 10 mg',
          cantidad: 5,
          precio: 75.00,
          impuesto: 0,
          total: 125.00
        },
        {
          medicamento_id: 2,
          descripcion: 'Diazepan 10 mg',
          cantidad: 5,
          precio: 75.00,
          impuesto: 0,
          total: 125.00
        },
        {
          medicamento_id: 2,
          descripcion: 'Diazepan 10 mg',
          cantidad: 5,
          precio: 75.00,
          impuesto: 0,
          total: 125.00
        },
        {
          medicamento_id: 2,
          descripcion: 'Diazepan 10 mg',
          cantidad: 5,
          precio: 75.00,
          impuesto: 0,
          total: 125.00
        },
        {
          medicamento_id: 4,
          descripcion: 'Dopamina 5mg',
          cantidad: 10,
          precio: 250.00,
          impuesto: 0,
          total: 2500.00
        }
      ]
    },
    {
      id: 3,
      user_id: 1,
      farmacia_id: 2,
      farmacia: 'Farmacia RX',
      receta_id: 1,
      fecha_compra: '06 Julio 2020',
      codigo_verificacion: 59728975,
      precioPagar: 2000.00,
      monto_cubierto: 243,
      tipo_pago: '',
      estado: 'Disponible para recojer',
      color_estado_secundario: 'warning',
      color_estado: 'warning',
      icono_estado: 'checkmark-outline',
      cajero: 'Marina de los Santos',
      detalles: [
        {
          medicamento_id: 2,
          descripcion: 'Loratadina 500 mg',
          cantidad: 2,
          precio: 1000.00,
          impuesto: 0,
          total: 2000.00
        }
      ]
    }
  ];

  constructor(private modalCtrl: ModalController) { }

  ngOnInit() {
  }

  //Obtener detalles de la compra(Modal)
  async openDetallesCompra(compra) {
    const modal = await this.modalCtrl.create({
      component: CompraDetailPage,
      componentProps: {
        compra: compra
      }
    });

    await modal.present();
  }
}
