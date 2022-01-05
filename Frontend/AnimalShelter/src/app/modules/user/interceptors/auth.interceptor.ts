import { AuthService } from './../services/auth.service';
import { Router } from '@angular/router';
import {
  HttpErrorResponse,
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  constructor(private router: Router, private authService: AuthService) {}

  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    const token = localStorage.getItem('userToken');

    if (token) {
      req = req.clone({
        setHeaders: {
          Authorization: `Bearer ${token}`,
        },
      });
    } else {
      if (this.router.url !== '/user') {
        this.router.navigate(['/user']);
      }
    }

    return next.handle(req).pipe(
      catchError((errorResponse: HttpErrorResponse) => {
        if (errorResponse.status === 401) {
          this.authService.setLogged(false);
          this.router.navigate(['/user']);
        } else if (errorResponse.status === 403) {
          console.error(errorResponse);
        }
        return throwError(errorResponse);
      })
    );
  }
}
