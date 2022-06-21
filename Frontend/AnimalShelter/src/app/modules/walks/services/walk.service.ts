import { USERS_URL } from './../../../shared/consts';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { WALKS_URL } from 'src/app/shared/consts';
import { Walk } from '../models/walk';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class WalkService {
  constructor(private http: HttpClient) {}

  getAllWalksForUser(userId: string): Observable<Walk[]> {
    const url = USERS_URL + `/${userId}/walks`;

    return this.http.get<Walk[]>(url);
  }
}
