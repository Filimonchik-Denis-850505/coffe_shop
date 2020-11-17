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
  
  basketList:Basket[] = JSON.parse(localStorage.getItem('basket')) || [];

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
        this.pushMes(item.name);
        return;
      }
    }
    this.basketList.push({productId:item.id,name:item.name,count:1,price:item.price});
    localStorage.setItem('basket',JSON.stringify(this.basketList));
    this.pushMes(item.name);
  }
  
  pushMes(product:string):void {
    
    let chips = document.createElement('div');
    chips.className = 'chips';
    chips.innerText = product + ' был добавлен в корзину';
    
    if(!document.querySelector('#chips-field')) {
      let chipsField = document.createElement('div');
      chipsField.id = 'chips-field';
      document.getElementById('queryContainer').appendChild(chipsField);
      document.querySelector('#chips-field').appendChild(chips);
    }
    
    document.querySelector('#chips-field').appendChild(chips);
    setTimeout(
        () => {
          chips.remove();
          
          let chipsAll = document.querySelectorAll('#chips-field .chips');
          if(chipsAll.length == 0)
          {
            document.querySelector('#chips-field').remove();
          }
        },
        3000
    );
  }
}
