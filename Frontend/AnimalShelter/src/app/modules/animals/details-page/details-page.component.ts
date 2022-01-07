import { AnimalsService } from './../services/animals.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Animal } from '../models/animal';
import { Img } from '../models/image';

@Component({
  selector: 'app-details-page',
  templateUrl: './details-page.component.html',
  styleUrls: ['./details-page.component.scss'],
})
export class DetailsPageComponent implements OnInit {
  animal: Animal;
  profileUrl: Img;
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
      this.profileUrl = this.animal.images.find(
        (i) => i.isProfilePicture === true
      );
      console.log(this.profileUrl);
    });
  }
}
