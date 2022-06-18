/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { TraitsListPageComponent } from './traits-list-page.component';

describe('ColorListPageComponent', () => {
  let component: TraitsListPageComponent;
  let fixture: ComponentFixture<TraitsListPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [TraitsListPageComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TraitsListPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
