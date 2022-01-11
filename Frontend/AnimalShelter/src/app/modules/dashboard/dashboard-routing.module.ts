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
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DashboardRoutingModule {}
