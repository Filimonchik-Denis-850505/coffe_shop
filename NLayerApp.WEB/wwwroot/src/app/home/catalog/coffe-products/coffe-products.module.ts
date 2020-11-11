import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CoffeProductsRoutingModule } from './coffe-products-routing.module';
import { CoffeProductsComponent } from './coffe-products.component';


@NgModule({
  declarations: [CoffeProductsComponent],
  imports: [
    CommonModule,
    CoffeProductsRoutingModule
  ]
})
export class CoffeProductsModule { }
