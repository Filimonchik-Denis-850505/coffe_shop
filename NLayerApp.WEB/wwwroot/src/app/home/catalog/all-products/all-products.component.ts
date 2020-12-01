import {Component, OnInit} from '@angular/core';
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
    isLoading = false;

    constructor(private catalogService: CatalogService) {
    }

    ngOnInit(): void {
        this.getAllProducts();

    }

    allProductList: Product[] = [];

    getAllProducts(): void {
        this.isLoading = true;
        setTimeout(() => this.catalogService.getProducts(),8000);
        this.catalogService.getProducts().subscribe(products => {
            this.isLoading = false;
            this.allProductList = products.sort((a, b) => b.price - a.price);
        });
    }

    addToBasket(item: Product): void {
        this.catalogService.addToBasket(item);
        console.log(this.allProductList);
    }
}
