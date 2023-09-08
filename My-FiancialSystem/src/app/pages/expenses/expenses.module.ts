import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';

import { ExpensesRoutingModule } from './expenses-routing.module';
import { ExpensesComponent } from './expenses.component';


@NgModule({
  declarations: [
    ExpensesComponent
  ],
  imports: [
    CommonModule,
    ExpensesRoutingModule,
    SidebarModule,
    NavbarModule,
    FormsModule,
    ReactiveFormsModule,
    NgSelectModule 

  ]
})
export class ExpensesModule { }
