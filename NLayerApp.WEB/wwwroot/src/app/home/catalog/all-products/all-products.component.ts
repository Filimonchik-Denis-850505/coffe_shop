import { Component, OnInit } from '@angular/core';
import {CatalogService} from "../catalog.service";
import {Product} from "../../../product";

@Component({
  selector: 'all-products',
  templateUrl: './all-products.component.html',
  styleUrls: ['./all-products.component.scss',
              '../catalog.component.scss'
  ]
})
export class AllProductsComponent implements OnInit {

  constructor(private catalogService: CatalogService) { }

  ngOnInit(): void {
    this.getAllProducts();
  }

  allProductList: Product[];

  getAllProducts(): void {
    this.catalogService.getProducts().subscribe(products =>this.allProductList = products);
  }

}
