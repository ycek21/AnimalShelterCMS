/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { HelpTableComponent } from './help-table.component';

describe('HelpTableComponent', () => {
  let component: HelpTableComponent;
  let fixture: ComponentFixture<HelpTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HelpTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HelpTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
