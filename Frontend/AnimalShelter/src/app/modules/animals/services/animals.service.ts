import { FormGroup } from '@angular/forms';
import { Traits } from './../models/traits';
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
    pageSize: number,
    filterForm: FormGroup
  ): Observable<HttpResponse<Animal[]>> {
    const url =
      ANIMALS_URL +
      `?PageSize=${pageSize}&PageNumber=${pageNumber}&AnimalType=${
        filterForm.get('animalType')?.value
      }&Color=${filterForm.get('color')?.value}&Size=${
        filterForm.get('size')?.value
      }&Age=${filterForm.get('maxAge')?.value}`;
    return this.http.get<Animal[]>(url, { observe: 'response' });
  }
  getAnimal(id: string): Observable<Animal> {
    const url = ANIMALS_URL + `/${id}`;
    return this.http.get<Animal>(url);
  }
  getTraits(): Observable<Traits> {
    const url = ANIMALS_URL + '/traits';
    return this.http.get<Traits>(url);
  }
  postAnimal(animalForm: FormGroup, files: File[]) {
    const url = ANIMALS_URL + '/animalWithPhoto';
    const formData = new FormData();
    formData.append('animalForCreation', JSON.stringify(animalForm.value));
    Array.from(files).map((file, index) => {
      return formData.append('files', file);
    });
    return this.http.post(url, formData);
  }
  getAnimalsWithoutFilter(
    pageNumber: number,
    pageSize: number
  ): Observable<HttpResponse<Animal[]>> {
    const url = ANIMALS_URL + `?PageSize=${pageSize}&PageNumber=${pageNumber}`;
    return this.http.get<Animal[]>(url, { observe: 'response' });
  }
  patchAnimalIsDead(animalId: string) {
    const url = ANIMALS_URL + `/${animalId}`;
    return this.http.patch(url, '');
  }
}
