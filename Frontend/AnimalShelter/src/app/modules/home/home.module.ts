import { HomeRoutingModule } from './home-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [CommonModule, HomeRoutingModule],
  declarations: [PageComponent],
})
export class HomeModule {}
