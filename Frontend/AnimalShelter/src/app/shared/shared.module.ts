import { CommonModule, DatePipe } from '@angular/common';
import { NgModule } from '@angular/core';
import { NotImplementedComponent } from './components/not-implemented/not-implemented.component';
import { SharedRoutingModule } from './shared-routing.module';

@NgModule({
  declarations: [NotImplementedComponent],
  imports: [CommonModule, SharedRoutingModule],
  exports: [CommonModule],
  providers: [DatePipe],
})
export class SharedModule {}
