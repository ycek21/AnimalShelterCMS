import {
  Component,
  Input,
  OnInit,
  EventEmitter,
  Output,
  OnChanges,
} from '@angular/core';
import { Observable } from 'rxjs';
import { Walk } from '../../models/walk';

@Component({
  selector: 'app-walk-table',
  templateUrl: './walk-table.component.html',
  styleUrls: ['./walk-table.component.scss'],
})
export class WalkTableComponent implements OnChanges {
  @Input() walks: Walk[];
  @Output() walkToDelete: EventEmitter<string> = new EventEmitter();
  displayedColumns: string[] = [
    'date',
    'animalName',
    'animalProfileImageUrl',
    'actions',
  ];

  constructor() {}

  ngOnChanges() {}

  public createImgPath = (serverPath: string) => {
    return `https://localhost:5001/${serverPath}`;
  };
  public deleteWalk(walkId: string) {
    this.walkToDelete.emit(walkId);
  }
}
