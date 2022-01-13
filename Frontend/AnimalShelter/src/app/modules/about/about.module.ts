import { AboutRoutingModule } from './about-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDividerModule } from '@angular/material/divider';

@NgModule({
  imports: [CommonModule, AboutRoutingModule, MatDividerModule],
  declarations: [PageComponent],
})
export class AboutModule {}
