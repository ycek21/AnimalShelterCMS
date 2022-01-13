import { DeleteAnimalPageComponent } from './delete-animal-page/delete-animal-page.component';
import { AddAnimalPageComponent } from './add-animal-page/add-animal-page.component';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: PageComponent,
    children: [
      {
        path: 'addAnimal',
        component: AddAnimalPageComponent,
      },
      {
        path: 'animalList',
        component: DeleteAnimalPageComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DashboardRoutingModule {}
