import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';

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

  constructor(private fb: FormBuilder) {}

  ngOnInit() {}
  login() {
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
