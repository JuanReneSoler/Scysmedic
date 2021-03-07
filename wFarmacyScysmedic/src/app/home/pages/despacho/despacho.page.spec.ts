import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { DespachoPage } from './despacho.page';

describe('DespachoPage', () => {
  let component: DespachoPage;
  let fixture: ComponentFixture<DespachoPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DespachoPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(DespachoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
