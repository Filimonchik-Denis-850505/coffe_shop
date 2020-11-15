import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MedHerbsProductsComponent } from './med-herbs-products.component';

const routes: Routes = [{ path: '', component: MedHerbsProductsComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MedHerbsProductsRoutingModule { }
