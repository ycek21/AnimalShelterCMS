import { AnimalsRoutingModule } from './animals-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatPaginatorModule } from '@angular/material/paginator';
import { DetailsPageComponent } from './details-page/details-page.component';
import { MatSelectModule } from '@angular/material/select';
import { MatCardModule } from '@angular/material/card';

@NgModule({
  imports: [
    CommonModule,
    AnimalsRoutingModule,
    MatPaginatorModule,
    MatSelectModule,
    MatCardModule,
  ],
  declarations: [PageComponent, DetailsPageComponent],
})
export class AnimalsModule {}
