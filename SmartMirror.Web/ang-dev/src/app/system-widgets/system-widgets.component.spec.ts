import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SystemWidgetsComponent } from './system-widgets.component';

describe('SystemWidgetsComponent', () => {
  let component: SystemWidgetsComponent;
  let fixture: ComponentFixture<SystemWidgetsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SystemWidgetsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SystemWidgetsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
