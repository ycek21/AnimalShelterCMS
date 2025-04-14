import { AdoptionsRoutingModule } from './adoptions-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [CommonModule, AdoptionsRoutingModule],
  declarations: [PageComponent],
})
export class AdoptionsModule {}
