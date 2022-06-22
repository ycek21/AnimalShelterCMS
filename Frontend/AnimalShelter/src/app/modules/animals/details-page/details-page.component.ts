import { DatePipe } from '@angular/common';
import { AnimalsService } from './../services/animals.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Animal } from '../models/animal';
import { Img } from '../models/image';
import { WalkForPost } from '../../walks/models/walkForPost';
import { WalkService } from '../../walks/services/walk.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { catchError } from 'rxjs';

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
    private animalsService: AnimalsService,
    private walkService: WalkService,
    private snackbarService: MatSnackBar,
    private router: Router
  ) {}

  ngOnInit() {
    const id = this.route.snapshot.paramMap.get('id');
    this.getAnimal(id);
  }

  postWalkWithAnimal(walk: WalkForPost) {
    this.walkService.postWalk(walk).subscribe(
      (walk) => {
        this.snackbarService.open('Walk was appointed.', 'Close', {
          duration: 4000,
        });

        this.router.navigate(['/walks']);
      },
      (error) => {
        const message = 'Walk wasnt appointed.' + error.error;
        this.snackbarService.open(message, 'Close', { duration: 4000 });
      }
    );
  }

  getAnimal(id: string) {
    this.animalsService.getAnimal(id).subscribe((resp) => {
      this.animal = resp;
      this.profileUrl = this.animal.images.find(
        (i) => i.isProfilePicture === true
      );
    });
  }
  transform(sex: boolean) {
    if (sex) {
      return 'Male';
    } else {
      return 'Female';
    }
  }
  public createImgPath = (serverPath: string) => {
    return `https://localhost:5001/${serverPath}`;
  };
}
