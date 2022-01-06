import { Observable } from 'rxjs';
import { ANIMALS_URL } from './../../../shared/consts';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Animal } from '../models/animal';

@Injectable({
  providedIn: 'root',
})
export class AnimalsService {
  constructor(private http: HttpClient) {}

  getAnimals(pageNumber: number, pageSize: number): Observable<Animal[]> {
    const url = ANIMALS_URL + `?PageSize=${pageSize}&PageNumber=${pageNumber}`;
    return this.http.get<Animal[]>(url);
  }
}
