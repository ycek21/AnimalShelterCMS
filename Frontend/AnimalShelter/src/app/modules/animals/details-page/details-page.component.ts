import { AnimalsService } from './../services/animals.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Animal } from '../models/animal';

@Component({
  selector: 'app-details-page',
  templateUrl: './details-page.component.html',
  styleUrls: ['./details-page.component.scss'],
})
export class DetailsPageComponent implements OnInit {
  animal: Animal;
  constructor(
    private route: ActivatedRoute,
    private animalsService: AnimalsService
  ) {}

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.getAnimal(id);
  }

  getAnimal(id: string) {
    this.animalsService.getAnimal(id).subscribe((resp) => {
      console.log(resp);
      this.animal = resp;
    });
  }
}
