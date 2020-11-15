import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { Product } from 'src/app/product';
import {Basket} from "../models/basket";

@Injectable({
  providedIn: 'root'
})
export class CatalogService {
  
  private productUrl = 'api/products';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  
  basketList:Basket[] = [];

  constructor(private http:HttpClient) { }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.productUrl)
  }
  
  getCategory(type:string): Observable<Product[]> {
    return this.http.get<Product[]>(this.productUrl + '/' + type);
  }
  
  addToBasket(item:Product):void {
    for (let i in this.basketList)
    {
      if(this.basketList[i].productId == item.id)
      {
        this.basketList[i].count++;
        localStorage.setItem('basket',JSON.stringify(this.basketList));
        return;
      }
    }
    this.basketList.push({productId:item.id,name:item.name,count:1,price:item.price});
    //localStorage.removeItem('basket');
    localStorage.setItem('basket',JSON.stringify(this.basketList));
  }
}
