import { AnimalsRoutingModule } from './animals-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [CommonModule, AnimalsRoutingModule],
  declarations: [PageComponent],
})
export class AnimalsModule {}
