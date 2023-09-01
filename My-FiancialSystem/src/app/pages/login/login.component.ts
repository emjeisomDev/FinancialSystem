import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

    constructor(public formBuilder: FormBuilder, private router: Router){}

    loginForm!: FormGroup;

    ngOnInit():void{
        this.loginForm = this.formBuilder.group(
            {
                email: ['',[Validators.required, Validators.email] ],
                password: ['', [Validators.required]]
            }
        )
    }

    get formData(){
        return this.loginForm.controls;
    }

    loginUser(){
        alert("Ok");
    }

}
