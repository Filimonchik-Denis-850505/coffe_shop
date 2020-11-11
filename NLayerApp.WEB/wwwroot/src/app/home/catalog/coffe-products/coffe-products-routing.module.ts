import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CoffeProductsComponent } from './coffe-products.component';

const routes: Routes = [{ path: '', component: CoffeProductsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CoffeProductsRoutingModule { }
