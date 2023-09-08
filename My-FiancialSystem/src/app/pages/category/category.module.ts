import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';

import { CategoryRoutingModule } from './category-routing.module';
import { CategoryComponent } from './category.component';


@NgModule({
  declarations: [
    CategoryComponent
  ],
  imports: [
    CommonModule,
    CategoryRoutingModule,
    NavbarModule,
    SidebarModule,
    FormsModule,
    ReactiveFormsModule,
    NgSelectModule
  ],
  exports:[
    CategoryComponent
  ]
})
export class CategoryModule { }
