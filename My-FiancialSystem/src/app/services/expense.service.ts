import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environment';
import { ExpenseModel } from '../models/ExpenseModel';

@Injectable({
  providedIn: 'root'
})
export class ExpenseService {

    constructor(private httpClient: HttpClient) { }

    private readonly baseUrl = environment["endPoint"];

    AddExpense(expense: ExpenseModel){
        return this.httpClient.post<ExpenseModel>(
            `${this.baseUrl}/AddExpense`,
            expense
        );
    }

    ListUserExpense(userEmail:string){
        return this.httpClient.get(
            `${this.baseUrl}/ListUserExpense?userEmail=${userEmail}`,
        );
    }

}
