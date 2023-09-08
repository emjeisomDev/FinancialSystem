import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FinancialSystemComponent } from './financial-system.component';

const routes: Routes = [
    {path:'',component:FinancialSystemComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FinancialSystemRoutingModule { }
