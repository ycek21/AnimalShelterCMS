import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Walk } from '../../models/walk';

@Component({
  selector: 'app-walk-table',
  templateUrl: './walk-table.component.html',
  styleUrls: ['./walk-table.component.scss'],
})
export class WalkTableComponent implements OnInit {
  @Input() walks: Walk[];
  displayedColumns: string[] = [
    'date',
    'animalName',
    'animalProfileImageUrl',
    'actions',
  ];

  constructor() {}

  ngOnInit() {}

  public createImgPath = (serverPath: string) => {
    return `https://localhost:5001/${serverPath}`;
  };
}
