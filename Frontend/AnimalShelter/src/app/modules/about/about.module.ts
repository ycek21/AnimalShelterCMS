import { AboutRoutingModule } from './about-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [CommonModule, AboutRoutingModule],
  declarations: [PageComponent],
})
export class AboutModule {}
