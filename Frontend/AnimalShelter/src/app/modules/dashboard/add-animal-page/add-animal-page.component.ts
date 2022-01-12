import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Traits } from '../../animals/models/traits';
import { AnimalsService } from '../../animals/services/animals.service';

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
    sex: [false, Validators.required],
    weight: ['', Validators.required],
    walkLimit: ['', Validators.required],
    sizeId: ['', Validators.required],
    colorId: ['', Validators.required],
    animalTypeId: ['', Validators.required],
  });
  profilePhotoUrl = '';
  filters: Traits;
  imagesList: File[] = [];
  addMoreImages = false;
  constructor(
    private fb: FormBuilder,
    private animalsService: AnimalsService,
    private router: Router
  ) {}

  ngOnInit() {
    this.getTraits();
  }

  uploadFile() {
    const fileUpload = document.getElementById(
      'fileUpload'
    ) as HTMLInputElement;
    fileUpload.click();
    fileUpload.onchange = (event) => {
      this.addMoreImages = false;
      var reader = new FileReader();
      this.imagesList = [];
      this.imagesList.push(fileUpload.files[0]);
      reader.readAsDataURL(fileUpload.files[0]);
      reader.onload = (event: any) => {
        this.profilePhotoUrl = event.target.result;
        this.addMoreImages = true;
      };
    };
  }
  getTraits() {
    this.animalsService.getTraits().subscribe((resp) => {
      this.filters = resp;
    });
  }
  addAnimal() {
    this.animalsService
      .postAnimal(this.animalForm, this.imagesList)
      .subscribe((resp) => {
        this.router.navigateByUrl('/animals');
      });
  }
  uploadFiles() {
    const filesUpload = document.getElementById(
      'fileUploads'
    ) as HTMLInputElement;
    filesUpload.click();
    filesUpload.onchange = (event) => {
      for (var i = 0; i < File.length; i++) {
        this.imagesList.push(filesUpload.files[i]);
      }
    };
  }
}
