import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MenuService } from 'src/app/services/menu.service';
import { SelectModel } from 'src/app/models/SelectModel';

@Component({
  selector: 'app-expenses',
  templateUrl: './expenses.component.html',
  styleUrls: ['./expenses.component.scss']
})
export class ExpensesComponent {
    constructor(public menuService:MenuService, public formBuilder: FormBuilder){}

    financialSystemList = new Array<SelectModel>();
    financialSystemSelected = new SelectModel();

    categoryList = new Array<SelectModel>();
    categorySelected = new SelectModel();

    expenseForm!: FormGroup;

    ngOnInit(){
        this.menuService.menuSelected = 4;
        this.expenseForm = this.formBuilder.group(
            {
                name: ['', [Validators.required]],
                expenseValue: ['', [Validators.required]],
                expenseDate: ['', [Validators.required]],
                financialSystemSelected: ['', [Validators.required]],
                categorySelected: ['', [Validators.required]],
            }
        )
    }

    dataForm() {
        return this.expenseForm.controls;
    }

    send() {
        debugger
        let data = this.dataForm();
    
        alert(data["name"].value)
      }

}
