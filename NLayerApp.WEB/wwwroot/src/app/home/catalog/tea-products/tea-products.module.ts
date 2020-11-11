import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TeaProductsRoutingModule } from './tea-products-routing.module';
import { TeaProductsComponent } from './tea-products.component';


@NgModule({
  declarations: [TeaProductsComponent],
  imports: [
    CommonModule,
    TeaProductsRoutingModule
  ]
})
export class TeaProductsModule { }
