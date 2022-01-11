import { HomeRoutingModule } from './home-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';

@NgModule({
  imports: [CommonModule, HomeRoutingModule, MatButtonModule, MatCardModule],
  declarations: [PageComponent],
})
export class HomeModule {}
