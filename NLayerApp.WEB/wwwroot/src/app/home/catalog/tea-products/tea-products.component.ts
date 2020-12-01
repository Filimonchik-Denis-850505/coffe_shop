import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog.service";
import {Product} from "../../../product";

@Component({
  selector: 'tea-products',
  templateUrl: './tea-products.component.html',
  styleUrls: ['./tea-products.component.scss',
              '../catalog.component.scss'
  ]
})
export class TeaProductsComponent implements OnInit {

  isLoading = false;
  
  constructor(private catalogService:CatalogService) { }

  ngOnInit(): void {
    this.getTea();
  }
  
  teaList:Product[];
  
  getTea():void {
    this.isLoading = true;
    this.catalogService.getCategory('tea').subscribe(products => {
          this.teaList = products;
          this.isLoading = false;
        }
    );
  }

  addToBasket(item:Product): void {
    this.catalogService.addToBasket(item);
  }

}
