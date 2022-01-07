import { Observable } from 'rxjs';
import { ANIMALS_URL } from './../../../shared/consts';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Animal } from '../models/animal';

@Injectable({
  providedIn: 'root',
})
export class AnimalsService {
  constructor(private http: HttpClient) {}

  getAnimals(
    pageNumber: number,
    pageSize: number
  ): Observable<HttpResponse<Animal[]>> {
    const url = ANIMALS_URL + `?PageSize=${pageSize}&PageNumber=${pageNumber}`;
    return this.http.get<Animal[]>(url, { observe: 'response' });
  }
  getAnimal(id: string): Observable<Animal> {
    const url = ANIMALS_URL + `/${id}`;
    return this.http.get<Animal>(url);
  }
}
