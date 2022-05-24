import { ColorService } from './../../services/colorService/color.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Trait } from '../../models/trait';

@Component({
  selector: 'app-color-list-page',
  templateUrl: './color-list-page.component.html',
  styleUrls: ['./color-list-page.component.scss'],
})
export class ColorListPageComponent implements OnInit {
  colors: Observable<Trait[]>;

  constructor(private colorService: ColorService) {}

  ngOnInit() {
    this.getAllColors();
  }

  private getAllColors(): void {
    this.colors = this.colorService.getAllColors();
  }
}
