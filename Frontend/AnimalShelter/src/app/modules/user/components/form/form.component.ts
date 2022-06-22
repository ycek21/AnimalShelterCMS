import jwt_decode from 'jwt-decode';
import { DecodedToken } from './../../models/decoded-token';
import { HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { AuthService } from './../../services/auth.service';
import { LoginCredentials } from './../../models/login-credentials';
import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss'],
})
export class FormComponent implements OnInit {
  loginForm: FormGroup = this.fb.group({
    email: ['', Validators.required],
    password: ['', Validators.required],
  });
  registerForm: FormGroup = this.fb.group({
    name: ['', Validators.required],
    surname: ['', Validators.required],
    dateOfBirth: ['', Validators.required],
    email: ['', Validators.required],
    password: [
      '',
      [Validators.required, Validators.minLength(6), this.validatorPassword],
    ],
  });

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router,
    private snackbarService: MatSnackBar
  ) {}

  ngOnInit() {}
  login() {
    const credentials: LoginCredentials = this.loginForm.value;
    credentials.email.trim();
    this.authService.login(credentials).subscribe(
      (response: HttpResponse<string>) => {
        const token = response.body!['token'];
        if (token) {
          const decodedToken: DecodedToken = jwt_decode(token);
          const userEmail =
            decodedToken[
              'http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name'
            ];
          const userRole =
            decodedToken[
              'http://schemas.microsoft.com/ws/2008/06/identity/claims/role'
            ];
          localStorage.setItem('userToken', token);
          localStorage.setItem('userEmail', userEmail);
          localStorage.setItem('userRole', userRole);
          this.authService.setLogged(true);
          this.snackbarService.open('Sucessfully logged in. ', 'Close', {
            duration: 4000,
          });
          this.router.navigate(['home']);
        }
      },
      (error: HttpErrorResponse) => {
        const message: string = error.error;
        this.snackbarService.open(message, 'Close', { duration: 4000 });
        this.loginForm.reset();
      }
    );
  }

  register() {
    this.authService.register(this.registerForm.value).subscribe(
      (resp) => {
        this.snackbarService.open(
          'Sucessfully registered. Confirm an email to login.',
          'Close',
          { duration: 4000 }
        );
        this.router.navigate(['/home']);
      },
      (error: HttpErrorResponse) => {
        let message: string = '';
        if (typeof error.error === 'object') {
          message = Object.values(error.error).join('');
        }
        this.snackbarService.open(message, 'Close', { duration: 4000 });
      }
    );
  }
  validatorPassword(fc: FormControl) {
    const value = fc.value as string;
    const isInvalid = 'password' === value.trim().toLowerCase();
    return isInvalid
      ? { passwordError: 'Password is not a strong password' }
      : null;
  }
}
