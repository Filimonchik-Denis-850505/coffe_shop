import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MedHerbsProductsRoutingModule } from './med-herbs-products-routing.module';
import { MedHerbsProductsComponent } from './med-herbs-products.component';


@NgModule({
  declarations: [MedHerbsProductsComponent],
  imports: [
    CommonModule,
    MedHerbsProductsRoutingModule
  ]
})
export class MedHerbsProductsModule { }
