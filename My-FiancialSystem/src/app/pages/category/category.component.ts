import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { SelectModel } from 'src/app/models/SelectModel';
import { MenuService } from 'src/app/services/menu.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent {

    constructor(public menuService: MenuService, public formBuilder: FormBuilder) {
    }

    financialSystemList = new Array<SelectModel>();
    financialSystemSelected = new SelectModel();

    categoryForm!: FormGroup;

    ngOnInit(){
        this.menuService.menuSelected = 3;
        this.categoryForm = this.formBuilder.group(
            {
                name: ['', [Validators.required]]
            }
        )
    }

    dataForm() {
        return this.categoryForm.controls;
    }

    send() {
        debugger
        let data = this.dataForm();
    
        alert(data["name"].value)
      }

}
