import { LoginCredentials } from './../models/login-credentials';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { DecodedToken } from '../models/decoded-token';
import jwt_decode from 'jwt-decode';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { LOGIN_URL } from 'src/app/shared/consts';
import { TimestampToDatePipe } from 'src/app/shared/pipes/timestamp-to-date.pipe';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private loginSubject$ = new BehaviorSubject<boolean>(this.decodeToken());

  constructor(
    private http: HttpClient,
    private timestampToDatePipe: TimestampToDatePipe
  ) {}

  private decodeToken() {
    const token = localStorage.getItem('userToken');

    if (token) {
      const decodedToken: DecodedToken = jwt_decode(token);
      const expirationDate = this.timestampToDatePipe.transform(
        decodedToken.exp
      );

      const currentDate = new Date();
      const isLogged = expirationDate > currentDate;
      return isLogged;
    } else {
      return false;
    }
  }
  login(credentials: LoginCredentials): Observable<HttpResponse<string>> {
    const url = LOGIN_URL;
    return this.http.post<string>(url, credentials, { observe: 'response' });
  }

  setLogged(isLogged: boolean) {
    if (!isLogged) {
      localStorage.clear();
    }
    this.loginSubject$.next(isLogged);
  }
  isUserLoggedIn(): Observable<boolean> {
    return this.loginSubject$.asObservable();
  }
}
