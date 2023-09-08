import { Component } from '@angular/core';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-expenses',
  templateUrl: './expenses.component.html',
  styleUrls: ['./expenses.component.scss']
})
export class ExpensesComponent {
    constructor(public menuService:MenuService){}
    ngOnInit(){
        this.menuService.menuSelected = 4;
    }
}
