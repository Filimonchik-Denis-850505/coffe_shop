import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Basket} from "../models/basket";
import {Order} from "../models/order";

@Injectable({
  providedIn: 'root'
})
export class BasketService {

  private productUrl = 'api/products';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  
  constructor(private http:HttpClient) { }
  
  createOrder(order:Order) {
    return this.http.post(this.productUrl,order);
  }
}
