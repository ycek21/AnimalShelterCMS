import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { WALKS_URL } from 'src/app/shared/consts';
import { Walk } from '../models/walk';

@Injectable({
  providedIn: 'root',
})
export class WalkService {
  constructor(private http: HttpClient) {}

  getAllWalksForUser() {
    const url = WALKS_URL;

    return this.http.get<Walk[]>(url);
  }
}
