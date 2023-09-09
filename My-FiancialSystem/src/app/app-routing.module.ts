import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { AuthGuard } from './pages/guards/auth-guard.service';

const routes: Routes = [
  {path: '', pathMatch: 'full', redirectTo: 'login'},
  {path: 'login', component: LoginComponent},
  {path: '', component: LoginComponent},
  {path: 'dashboard', loadChildren: () => import('./pages/dashboard/dashboard.module').then(m => m.DashboardModule), canActivate:[AuthGuard]},
  {path: 'sistema', loadChildren: () => import('./pages/financial-system/financial-system.module').then(m => m.FinancialSystemModule), canActivate:[AuthGuard]},
  {path: 'categoria', loadChildren: () => import('./pages/category/category.module').then(m => m.CategoryModule), canActivate:[AuthGuard]},
  {path: 'despesa', loadChildren: () => import('./pages/expenses/expenses.module').then(m => m.ExpensesModule), canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
