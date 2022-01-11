import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-animal-page',
  templateUrl: './add-animal-page.component.html',
  styleUrls: ['./add-animal-page.component.scss'],
})
export class AddAnimalPageComponent implements OnInit {
  animalForm: FormGroup = this.fb.group({
    name: ['', Validators.required],
    dateOfBirth: ['', Validators.required],
    description: ['', Validators.required],
    character: ['', Validators.required],
    sex: ['', Validators.required],
    weight: ['', Validators.required],
    walkLimit: ['', Validators.required],
    views: ['', Validators.required],
    isDead: [false, Validators.required],
    modifiedAt: ['', Validators.required],
    size: ['', Validators.required],
    color: ['', Validators.required],
    animalType: ['', Validators.required],
  });
  profilePhotoUrl = '';

  constructor(private fb: FormBuilder) {}

  ngOnInit() {}
  selectFile(event: any) {
    if (event.target.files) {
      var reader = new FileReader();
      reader.readAsDataURL(event.target.files[0]);
      reader.onload = (event: any) => {
        console.log(event);
        this.profilePhotoUrl = event.target.result;
      };
    }
  }
}
