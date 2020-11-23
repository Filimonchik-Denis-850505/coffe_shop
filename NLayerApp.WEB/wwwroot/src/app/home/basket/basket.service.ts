import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpResponse} from "@angular/common/http";
import {Basket} from "../models/basket";
import {Order} from "../models/order";
import {Observable} from "rxjs";
import {Product} from "../../product";

@Injectable({
  providedIn: 'root'
})
export class BasketService {

  private productUrl = 'api/orders';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };
  
  constructor(private http:HttpClient) { }
  
  createOrder(order:Order) {
    return this.http.post(this.productUrl,order,{ observe: 'response' });
  }
}
