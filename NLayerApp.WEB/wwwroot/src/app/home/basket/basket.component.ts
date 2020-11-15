import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog/catalog.service";
import {Basket} from "../models/basket";
import {FormArray} from "@angular/forms";

@Component({
  selector: 'basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.scss']
})
export class BasketComponent implements OnInit {

  constructor(private catalogService: CatalogService) { }

  basketList:Basket[] = [];
  sum:number = 0;
  
  ngOnInit(): void {
    this.updateBasket();
    this.totalAmount();
  }
  
  updateBasket():void {
    //this.basketList = this.catalogService.basketList;
    this.basketList = JSON.parse(localStorage.getItem('basket'));
  }
  
  totalAmount(): void {
    for (let i in this.basketList) {
      this.sum += this.basketList[i].count * this.basketList[i].price;
    }
  }
}
