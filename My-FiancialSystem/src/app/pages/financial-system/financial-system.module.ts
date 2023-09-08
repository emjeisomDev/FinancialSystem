import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';

import { FinancialSystemRoutingModule } from './financial-system-routing.module';
import { FinancialSystemComponent } from './financial-system.component';


@NgModule({
  declarations: [
    FinancialSystemComponent
  ],
  imports: [
    CommonModule,
    FinancialSystemRoutingModule,
    NavbarModule,
    SidebarModule,
    ReactiveFormsModule
  ],
  exports:[
    FinancialSystemComponent
  ]
})
export class FinancialSystemModule { }
