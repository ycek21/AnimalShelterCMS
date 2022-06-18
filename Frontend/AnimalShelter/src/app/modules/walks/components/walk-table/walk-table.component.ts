import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Walk } from '../../models/walk';

@Component({
  selector: 'app-walk-table',
  templateUrl: './walk-table.component.html',
  styleUrls: ['./walk-table.component.scss'],
})
export class WalkTableComponent implements OnInit {
  @Input() walks: Observable<Walk[]>;
  displayedColumns: string[] = ['name', 'date', 'actions'];

  constructor() {}

  ngOnInit() {}
}
