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
    private router: Router
  ) {}

  ngOnInit() {}
  login() {
    const credentials: LoginCredentials = this.loginForm.value;
    credentials.email.trim();
    this.authService.login(credentials).subscribe(
      (response: HttpResponse<string>) => {
        const token = response.headers.get('Authorization');

        if (token) {
          const decodedToken: DecodedToken = jwt_decode(token);
          localStorage.setItem('userToken', token);
          this.authService.setLogged(true);
          this.router.navigate(['home']);
        }
      },
      (error: HttpErrorResponse) => {
        if (error.status === 403) {
          console.log('iSForbidded');
          this.loginForm.reset();
        }
      }
    );

    console.log(this.loginForm.value);
  }

  register() {
    console.log(this.registerForm.value);
  }
  validatorPassword(fc: FormControl) {
    const value = fc.value as string;
    const isInvalid = 'password' === value.trim().toLowerCase();
    return isInvalid
      ? { passwordError: 'Password is not a strong password' }
      : null;
  }
}
