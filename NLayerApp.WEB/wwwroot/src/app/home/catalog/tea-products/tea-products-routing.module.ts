import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TeaProductsComponent } from './tea-products.component';

const routes: Routes = [{ path: '', component: TeaProductsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TeaProductsRoutingModule { }
