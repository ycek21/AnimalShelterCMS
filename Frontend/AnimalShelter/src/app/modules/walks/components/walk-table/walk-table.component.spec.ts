/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { WalkTableComponent } from './walk-table.component';

describe('WalkTableComponent', () => {
  let component: WalkTableComponent;
  let fixture: ComponentFixture<WalkTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WalkTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WalkTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
