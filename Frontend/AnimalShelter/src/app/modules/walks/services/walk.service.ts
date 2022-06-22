import { USERS_URL } from './../../../shared/consts';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { WALKS_URL } from 'src/app/shared/consts';
import { Walk } from '../models/walk';
import { Observable } from 'rxjs';
import { WalkForPost } from '../models/walkForPost';

@Injectable({
  providedIn: 'root',
})
export class WalkService {
  constructor(private http: HttpClient) {}

  getAllWalksForUser(userId: string): Observable<Walk[]> {
    const url = USERS_URL + `/${userId}/walks`;

    return this.http.get<Walk[]>(url);
  }
  deleteWalk(walkId: string) {
    const url = WALKS_URL + `/${walkId}`;

    return this.http.delete(url);
  }

  postWalk(walk: WalkForPost): Observable<Walk> {
    const url = WALKS_URL;

    walk.DateOfWalk.setSeconds(0, 0);

    return this.http.post<Walk>(url, walk);
  }
}
