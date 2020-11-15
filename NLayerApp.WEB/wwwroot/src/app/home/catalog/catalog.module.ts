import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CatalogRoutingModule } from './catalog-routing.module';
import {CatalogComponent} from "./catalog.component";
import {AllProductsModule} from "./all-products/all-products.module";




@NgModule({
    declarations: [CatalogComponent],
    exports: [
        CatalogComponent
    ],
    imports: [
        CommonModule,
        CatalogRoutingModule,
        AllProductsModule,
    ]
})
export class CatalogModule { }
