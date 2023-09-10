import { FinancialSystemModel } from './../models/FinancialSystemModel';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environment';

@Injectable({
    providedIn: 'root'
})
export class FinancialsystemService {

    constructor(private httpClient: HttpClient) { }

    private readonly baseUrl = environment["endPoint"];

    AddFiancialSystem(financialSystem: FinancialSystemModel){
        return this.httpClient.post<FinancialSystemModel>(
            `${this.baseUrl}/AddFiancialSystem`,
            financialSystem
        );
    }

    ListUserSystem(userEmail: string){
        return this.httpClient.get(
            `${this.baseUrl}/ListUserSystem?userEmail=${userEmail}`,
        );
    }

    AddUserFinancialSystem(idSystem: number, userEmail: string){
        return this.httpClient.post<FinancialSystemModel>(
            `${this.baseUrl}/AddUserFinancialSystem?idSystem=${idSystem}&userEmail=${userEmail}`, null
        );
    }




}
