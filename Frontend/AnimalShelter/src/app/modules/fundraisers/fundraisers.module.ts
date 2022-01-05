import { FundraisersRoutingModule } from './fundraisers-routing.module';
import { PageComponent } from './page/page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [CommonModule, FundraisersRoutingModule],
  declarations: [PageComponent],
})
export class FundraisersModule {}
