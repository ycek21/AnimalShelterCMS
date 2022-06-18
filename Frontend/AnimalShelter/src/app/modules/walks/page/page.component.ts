import { Walk } from './../models/walk';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-page',
  templateUrl: './page.component.html',
  styleUrls: ['./page.component.scss'],
})
export class PageComponent implements OnInit {
  walks: Observable<Walk[]>;
  constructor() {}

  ngOnInit() {}
}
