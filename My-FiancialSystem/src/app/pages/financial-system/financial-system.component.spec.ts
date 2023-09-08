import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FinancialSystemComponent } from './financial-system.component';

describe('FinancialSystemComponent', () => {
  let component: FinancialSystemComponent;
  let fixture: ComponentFixture<FinancialSystemComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [FinancialSystemComponent]
    });
    fixture = TestBed.createComponent(FinancialSystemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
