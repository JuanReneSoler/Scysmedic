import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { CompraDetailPage } from './compra-detail.page';

describe('CompraDetailPage', () => {
  let component: CompraDetailPage;
  let fixture: ComponentFixture<CompraDetailPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CompraDetailPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(CompraDetailPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
