import { Component, OnInit } from '@angular/core';
import { PopoverController } from '@ionic/angular';

@Component({
  selector: 'app-poopcion',
  templateUrl: './poopcion.component.html',
  styleUrls: ['./poopcion.component.scss'],
})
export class PoopcionComponent implements OnInit {

  constructor(private popoverCtrl: PopoverController) { }

  ngOnInit() {}

  onClick(valor: string){
    console.log(valor);

    this.popoverCtrl.dismiss({
      item: valor
    });
  }
}
