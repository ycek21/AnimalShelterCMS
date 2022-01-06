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

  @ViewChild(MatPaginator) paginator: MatPaginator;

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
          if (data === null) {
            return [];
          }
          return data;
        })
      )
      .subscribe((data) => {
        console.log(data);
        this.dataSource = data;
      });
  }

  getAnimals(pageIndex: number, pageSize: number) {
    return this.animalsService.getAnimals(pageIndex, pageSize);
  }
}
