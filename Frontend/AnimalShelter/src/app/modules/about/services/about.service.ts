import { Observable } from 'rxjs';
import { CONFIGS_URL } from './../../../shared/consts';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ConfigAsDict } from '../models/configAsDict';

@Injectable({
  providedIn: 'root',
})
export class AboutService {
  constructor(private http: HttpClient) {}

  getAllInformation(): Observable<ConfigAsDict> {
    const url = CONFIGS_URL + `/configsAsDict`;
    return this.http.get<ConfigAsDict>(url);
  }
}
