import { BASE_URL } from './../../../../shared/consts';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Trait } from '../../models/trait';

@Injectable({
  providedIn: 'root',
})
export class ColorService {
  constructor(private http: HttpClient) {}

  public getAllColors(): Observable<Trait[]> {
    const url = BASE_URL + `color`;
    return this.http.get<Trait[]>(url);
  }
}
