import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})

export class AuthService
{
    private userAuthenticatedOnPortal: boolean = false;
    private token: any;
    private user: any;

    constructor(private httpClient: HttpClient)
    {}

    checkToken(){
        return Promise.resolve(true);
    }

    userAuthenticated(status:boolean){
        localStorage.setItem('userAuthenticatedOnPortal', JSON.stringify(status));
        this.userAuthenticatedOnPortal = status;
    }

    isUserAuthenticated(): Promise<boolean> {
        this.userAuthenticatedOnPortal = localStorage.getItem('userAuthenticatedOnPortal') == 'true';
        return Promise.resolve(this.userAuthenticatedOnPortal);
    }

    setToken(token: string){
        localStorage.setItem('token', token);
        this.token = token;
    }

    get getToken(){
        this.token = localStorage.getItem('token');
        return this.token;
    }

    clearToken(){
        this.token = null;
        this.user = null;
    }

    cleanUserData(){
        this.userAuthenticated(false);
        this.clearToken();
        localStorage.clear();
        sessionStorage.clear();
    }

}
