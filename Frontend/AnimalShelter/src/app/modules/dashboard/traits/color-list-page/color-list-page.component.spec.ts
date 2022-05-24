/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ColorListPageComponent } from './color-list-page.component';

describe('ColorListPageComponent', () => {
  let component: ColorListPageComponent;
  let fixture: ComponentFixture<ColorListPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ColorListPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ColorListPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
