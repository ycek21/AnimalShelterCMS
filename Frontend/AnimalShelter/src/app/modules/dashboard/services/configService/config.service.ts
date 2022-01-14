import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Config } from '../../models/config';
import { CONFIG_URL } from './../../../../shared/consts';

@Injectable({
  providedIn: 'root',
})
export class ConfigService {
  constructor(private http: HttpClient) {}

  public getAllConfigs(): Observable<Config[]> {
    const url = CONFIG_URL;

    return this.http.get<Config[]>(url);
  }

  public patchConfig(config: { key: string; value: string }) {
    const url = CONFIG_URL + '/' + config.key;

    const body = { value: config.value };

    return this.http.patch(url, body);
  }
}
