import { NavigationEnd, Router } from '@angular/router';
import { AnimalsService } from './../services/animals.service';
import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { Animal } from '../models/animal';
import { MatPaginator } from '@angular/material/paginator';
import { catchError, filter, map, merge, startWith, switchMap } from 'rxjs';
import { Types } from '../models/type';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Traits } from '../models/traits';

@Component({
  selector: 'app-page',
  templateUrl: './page.component.html',
  styleUrls: ['./page.component.scss'],
})
export class PageComponent implements OnInit, AfterViewInit {
  dataSource: Animal[] = [];
  resultLength = 0;
  filterForm: FormGroup = this.fb.group({
    size: [''],
    color: [''],
    animalType: [''],
  });
  filters: Traits;

  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(
    private animalsService: AnimalsService,
    private router: Router,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.getTraits();
    this.checkUrl();
  }

  ngAfterViewInit() {
    merge(this.paginator.page, this.filterForm.valueChanges)
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
    return this.animalsService.getAnimals(pageIndex, pageSize, this.filterForm);
  }
  goToAnimal(id: string) {
    this.router.navigate([`animals/${id}`]);
  }
  clearFilter() {
    this.filterForm.reset({
      size: '',
      color: '',
      animalType: '',
    });
  }
  getTraits() {
    this.animalsService.getTraits().subscribe((resp) => {
      this.filters = resp;
    });
  }
  checkUrl() {
    let url = this.router.url.split('/').pop();
    if (url === 'dogs') {
      this.filterForm.patchValue({
        animalType: 'Pies',
      });
    } else if (url === 'cats') {
      this.filterForm.patchValue({
        animalType: 'Kot',
      });
    }
  }
  public createImgPath = (serverPath: string) => {
    return `https://localhost:5001/${serverPath}`;
  };
}
