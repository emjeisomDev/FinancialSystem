import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environment';
import { CategoryModel } from '../models/CategoryModel';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

    constructor(private httpClient: HttpClient) { }

    private readonly baseUrl = environment["endPoint"];

    AddCategory(category: CategoryModel){
        return this.httpClient.post<CategoryModel>(
            `${this.baseUrl}/AddCategory`,
            category
        );
    }

    ListUserCategory(userEmail:string){
        return this.httpClient.get(
            `${this.baseUrl}/ListUserCategory?userEmail=${userEmail}`,
        );
    }





}
