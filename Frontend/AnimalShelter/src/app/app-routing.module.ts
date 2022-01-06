import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'about',
    loadChildren: () =>
      import('./modules/about/about.module').then((m) => m.AboutModule),
  },
  {
    path: 'home',
    loadChildren: () =>
      import('./modules/home/home.module').then((m) => m.HomeModule),
  },
  {
    path: 'fundraisers',
    loadChildren: () =>
      import('./modules/fundraisers/fundraisers.module').then(
        (m) => m.FundraisersModule
      ),
  },
  {
    path: 'adoptions',
    loadChildren: () =>
      import('./modules/adoptions/adoptions.module').then(
        (m) => m.AdoptionsModule
      ),
  },
  {
    path: 'user',
    loadChildren: () =>
      import('./modules/user/user.module').then((m) => m.UserModule),
  },
  {
    path: 'animals',
    loadChildren: () =>
      import('./modules/animals/animals.module').then((m) => m.AnimalsModule),
  },
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
