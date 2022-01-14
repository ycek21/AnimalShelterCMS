import { Component, OnInit } from '@angular/core';
import { AboutService } from '../services/about.service';
import { ConfigAsDict } from '../models/configAsDict';

@Component({
  selector: 'app-page',
  templateUrl: './page.component.html',
  styleUrls: ['./page.component.scss'],
})
export class PageComponent implements OnInit {
  informations: ConfigAsDict;
  constructor(private aboutService: AboutService) {}

  ngOnInit() {
    this.getAllInformation();
  }

  getAllInformation() {
    this.aboutService.getAllInformation().subscribe((resp) => {
      this.informations = resp;
    });
  }
}
