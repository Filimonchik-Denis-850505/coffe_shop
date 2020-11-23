import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog/catalog.service";
import {Basket} from "../models/basket";
import {Order} from "../models/order";
import {BasketService} from "./basket.service";
import {OrderProduct} from "../models/order-product";
import {HttpRequest, HttpResponse} from "@angular/common/http";
import {timeout} from "rxjs/operators";

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
  
  response:Order = new Order();
  responseStatus: boolean = false;
  
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
    
    let i = 0;
    
    this.createOrderModel();
    
    console.log(this.order);
    
    this.basketService.createOrder(this.order).subscribe((data: HttpResponse<Order>) => {
    this.responseValid(data); if(this.responseStatus) this.clearBasket(); this.showPopup()});
  }
  
  createOrderModel(): void {
    for(let i in this.basketList) {
      this.order.productOrders.push({productId:this.basketList[i].productId,count:this.basketList[i].count});
    }
  }
  
  responseValid(data:HttpResponse<any>) : void {
    
    if(data.body == "Error") {
      this.responseStatus = false;
      return;
    }
    
    this.responseStatus = true;
    this.response = data.body;
  }
  
  showPopup(): void {
    let popup = document.getElementById('popup'),
        popupClose = document.getElementById('popup-close');
    
    popup.style.display = "block";
    
    popupClose.onclick = function () {
      popup.style.display = "none";
    }
    
    window.onclick = function (e) {
      if(e.target == popup)
      {
        popup.style.display = "none";
      }
    }
  }
}
