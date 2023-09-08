import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-financial-system',
  templateUrl: './financial-system.component.html',
  styleUrls: ['./financial-system.component.scss']
})
export class FinancialSystemComponent {
    constructor(public menuService:MenuService, public formBuilder: FormBuilder){}

    financialSystemForm!: FormGroup;


    ngOnInit(){
        this.menuService.menuSelected = 2;

        this.financialSystemForm = this.formBuilder.group({
            name: ['', [Validators.required]]
        });
    }

    dataForm(){
        return this.financialSystemForm.controls;
    }

    send(){
        debugger
        let data = this.dataForm();
        alert(data["name"].value);
    }



}
