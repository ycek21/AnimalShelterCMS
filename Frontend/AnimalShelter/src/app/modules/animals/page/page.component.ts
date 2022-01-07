import { Router } from '@angular/router';
import { AnimalsService } from './../services/animals.service';
import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { Animal } from '../models/animal';
import { MatPaginator } from '@angular/material/paginator';
import { catchError, map, merge, startWith, switchMap } from 'rxjs';

@Component({
  selector: 'app-page',
  templateUrl: './page.component.html',
  styleUrls: ['./page.component.scss'],
})
export class PageComponent implements OnInit, AfterViewInit {
  dataSource: Animal[] = [];
  resultLength = 0;

  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(private animalsService: AnimalsService, private router: Router) {}

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
        this.resultLength = xpagination.TotalCount;
        this.dataSource = data.body;
      });
  }

  getAnimals(pageIndex: number, pageSize: number) {
    return this.animalsService.getAnimals(pageIndex, pageSize);
  }
  goToAnimal(id: string) {
    this.router.navigate([`animals/${id}`]);
  }
}
