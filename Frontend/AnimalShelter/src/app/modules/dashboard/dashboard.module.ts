import { ColorListPageComponent } from './traits/color-list-page/color-list-page.component';
import { HelpTableComponent } from './components/help-table/help-table.component';
import { DeleteAnimalPageComponent } from './delete-animal-page/delete-animal-page.component';
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
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { FlexLayoutModule } from '@angular/flex-layout';
import { UserPageComponent } from './page/user-page/user-page/user-page.component';
import { UserTableComponent } from './components/user-table/user-table.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatTableModule } from '@angular/material/table';
import { ConfigPageComponent } from './page/config-page/config-page/config-page.component';
import { ConfigTableComponent } from './components/config-table/config-table/config-table.component';
import {
  MatDialogModule,
  MAT_DIALOG_DEFAULT_OPTIONS,
} from '@angular/material/dialog';
import { PatchConfigDialogComponent } from './components/patch-config-dialog/patch-config-dialog/patch-config-dialog.component';

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
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatSelectModule,
    FlexLayoutModule,
    MatPaginatorModule,
    MatProgressSpinnerModule,
    MatTableModule,
    MatDialogModule,
  ],
  declarations: [
    SidebarComponent,
    PageComponent,
    AddAnimalPageComponent,
    UserPageComponent,
    UserTableComponent,
    DeleteAnimalPageComponent,
    ConfigPageComponent,
    ConfigTableComponent,
    PatchConfigDialogComponent,
    HelpTableComponent,
    ColorListPageComponent,
  ],
})
export class DashboardModule {}
