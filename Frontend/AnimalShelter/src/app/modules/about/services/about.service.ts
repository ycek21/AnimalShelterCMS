import { Config } from './../models/config';
import { Observable } from 'rxjs';
import { CONFIGS_URL } from './../../../shared/consts';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AboutService {
  constructor(private http: HttpClient) {}

  getAllInformation(): Observable<Config[]> {
    const url = CONFIGS_URL;
    return this.http.get<Config[]>(url);
  }
}
