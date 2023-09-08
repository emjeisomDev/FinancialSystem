import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FinancialSystemRoutingModule } from './financial-system-routing.module';
import { FinancialSystemComponent } from './financial-system.component';
import { NavbarModule } from 'src/app/components/navbar/navbar.module';
import { SidebarModule } from 'src/app/components/sidebar/sidebar.module';


@NgModule({
  declarations: [
    FinancialSystemComponent
  ],
  imports: [
    CommonModule,
    FinancialSystemRoutingModule,
    NavbarModule,
    SidebarModule
  ],
  exports:[
    FinancialSystemComponent
  ]
})
export class FinancialSystemModule { }
