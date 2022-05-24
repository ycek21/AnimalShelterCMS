import { ColorListPageComponent } from './traits/color-list-page/color-list-page.component';
import { DeleteAnimalPageComponent } from './delete-animal-page/delete-animal-page.component';
import { AddAnimalPageComponent } from './add-animal-page/add-animal-page.component';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserPageComponent } from './page/user-page/user-page/user-page.component';
import { ConfigPageComponent } from './page/config-page/config-page/config-page.component';

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
        path: 'users',
        component: UserPageComponent,
      },
      {
        path: 'animalList',
        component: DeleteAnimalPageComponent,
      },
      {
        path: 'config',
        component: ConfigPageComponent,
      },
      {
        path: 'colorList',
        component: ColorListPageComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DashboardRoutingModule {}
