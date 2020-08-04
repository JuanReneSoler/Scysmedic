import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { MyhealthPage } from './myhealth.page';

describe('MyhealthPage', () => {
  let component: MyhealthPage;
  let fixture: ComponentFixture<MyhealthPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MyhealthPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(MyhealthPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
