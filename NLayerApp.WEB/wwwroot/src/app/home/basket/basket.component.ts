import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog/catalog.service";
import {Basket} from "../models/basket";
import {Order} from "../models/order";
import {BasketService} from "./basket.service";
import {OrderProduct} from "../models/order-product";
import {HttpRequest, HttpResponse} from "@angular/common/http";

@Component({
  selector: 'basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.scss']
})
export class BasketComponent implements OnInit {

  constructor(private catalogService: CatalogService,private basketService:BasketService) { }

  order:Order = new Order();
  
  basketList:Basket[] = [];
  sum:number = 0;
  
  ngOnInit(): void {
    this.updateBasket();
    this.totalAmount();
  }
  
  updateBasket():void {
    this.basketList = JSON.parse(localStorage.getItem('basket'));
  }
  
  totalAmount(): void {
    this.sum = 0;
    for (let i in this.basketList) {
      this.sum += this.basketList[i].count * this.basketList[i].price;
    }
  }
  
  deleteProduct(item:Basket): void {
    this.basketList.splice(this.basketList.indexOf(item),1);
    localStorage.setItem('basket',JSON.stringify(this.basketList));
    this.catalogService.basketList = JSON.parse(localStorage.getItem('basket')) || [];
    this.totalAmount();
  }
  
  clearBasket(): void {
    this.basketList = [];
    localStorage.setItem('basket',JSON.stringify([]));
    this.catalogService.basketList = [];
    this.sum = 0;
  }
  
  minusProduct(item:Basket): void {
    this.basketList[this.basketList.indexOf(item)].count--;
    
    if (this.basketList[this.basketList.indexOf(item)].count == 0) this.deleteProduct(item);
    
    localStorage.setItem('basket',JSON.stringify(this.basketList));
    this.catalogService.basketList = JSON.parse(localStorage.getItem('basket')) || [];
    this.totalAmount();
  }

  plusProduct(item:Basket): void {
    this.basketList[this.basketList.indexOf(item)].count++;
    localStorage.setItem('basket',JSON.stringify(this.basketList));
    this.catalogService.basketList = JSON.parse(localStorage.getItem('basket')) || [];
    this.totalAmount();
  }
  
  sendOrder(): void {
    this.order.productOrders = [];
    
    this.createOrderModel();
    
    console.log(this.order);
    
    this.basketService.createOrder(this.order).subscribe((data: HttpResponse<Order>) => {
      console.log(data);});
    
    this.clearBasket();
  }
  
  createOrderModel(): void {
    for(let i in this.basketList) {
      this.order.productOrders.push({productId:this.basketList[i].productId,count:this.basketList[i].count});
    }
  }
}
