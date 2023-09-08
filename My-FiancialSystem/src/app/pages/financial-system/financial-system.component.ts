import { Component } from '@angular/core';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-financial-system',
  templateUrl: './financial-system.component.html',
  styleUrls: ['./financial-system.component.scss']
})
export class FinancialSystemComponent {
    constructor(public menuService:MenuService){}
    ngOnInit(){
        this.menuService.menuSelected = 2;
    }
}
