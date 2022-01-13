import { AnimalsService } from './../../animals/services/animals.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { Animal } from '../../animals/models/animal';
import { map, merge, startWith, switchMap } from 'rxjs';

@Component({
  selector: 'app-delete-animal-page',
  templateUrl: './delete-animal-page.component.html',
  styleUrls: ['./delete-animal-page.component.scss'],
})
export class DeleteAnimalPageComponent implements OnInit {
  displayedColumns: string[] = [
    'name',
    'animalType',
    'dateOfBirth',
    'sex',
    'weight',
    'views',
    'modifiedAt',
    'actions',
  ];
  data: Animal[] = [];
  @ViewChild(MatPaginator) paginator: MatPaginator;
  resultsLength = 0;
  isLoadingResults = true;
  constructor(private animalsService: AnimalsService) {}

  ngOnInit() {}

  ngAfterViewInit() {
    merge(this.paginator.page)
      .pipe(
        startWith({}),
        switchMap(() => {
          return this.getAnimals(
            this.paginator.pageIndex + 1,
            this.paginator.pageSize
          );
        }),
        map((data: any) => {
          this.isLoadingResults = false;
          if (data === null) {
            return [];
          }
          return data;
        })
      )
      .subscribe((data) => {
        let xpagination: {
          TotalPages: number;
          PageSize: number;
          TotalCount: number;
          HasPrevious: boolean;
          HasNext: boolean;
        } = JSON.parse(data.headers.get('X-Pagination'));
        this.resultsLength = xpagination?.TotalCount;
        this.data = data.body;
      });
  }
  getAnimals(pageIndex: number, pageSize: number) {
    return this.animalsService.getAnimalsWithoutFilter(pageIndex, pageSize);
  }
  displaySex(sex: boolean) {
    if (sex) {
      return 'Male';
    } else {
      return 'Female';
    }
  }
  passedAway(animalId: string) {
    this.animalsService.patchAnimalIsDead(animalId).subscribe((resp) => {
      this.paginator._changePageSize(this.paginator.pageSize);
    });
  }
}
