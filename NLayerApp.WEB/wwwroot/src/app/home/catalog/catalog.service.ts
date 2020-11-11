import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { Product } from 'src/app/product';

@Injectable({
  providedIn: 'root'
})
export class CatalogService {
  
  private productUrl = 'api/products';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  private string: string;

  constructor(private http:HttpClient) { }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.productUrl)
  }
  
  getCategory(type:string): Observable<Product[]> {
    return this.http.get<Product[]>(this.productUrl + '/' + type);
  }
}
