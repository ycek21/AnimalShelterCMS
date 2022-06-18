import { Component, Input, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Trait } from '../../models/trait';

@Component({
  selector: 'app-help-table',
  templateUrl: './help-table.component.html',
  styleUrls: ['./help-table.component.scss'],
})
export class HelpTableComponent implements OnInit {
  @Input() data: Observable<Trait[]>;
  constructor() {}

  displayedColumns: string[] = ['on', 'value'];

  ngOnInit() {}
}
