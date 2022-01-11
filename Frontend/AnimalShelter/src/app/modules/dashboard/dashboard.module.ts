import { AddAnimalPageComponent } from './add-animal-page/add-animal-page.component';
import { PageComponent } from './page/page.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCardModule } from '@angular/material/card';
import { MatMenuModule } from '@angular/material/menu';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatTreeModule } from '@angular/material/tree';
import { MatExpansionModule } from '@angular/material/expansion';

@NgModule({
  imports: [
    CommonModule,
    DashboardRoutingModule,
    MatGridListModule,
    MatCardModule,
    MatMenuModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatTreeModule,
    MatExpansionModule,
  ],
  declarations: [SidebarComponent, PageComponent, AddAnimalPageComponent],
})
export class DashboardModule {}
