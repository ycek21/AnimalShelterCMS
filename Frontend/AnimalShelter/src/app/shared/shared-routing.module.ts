import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NotImplementedComponent } from './components/not-implemented/not-implemented.component';

const routes: Routes = [
  {
    path: '',
    component: NotImplementedComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class SharedRoutingModule {}
