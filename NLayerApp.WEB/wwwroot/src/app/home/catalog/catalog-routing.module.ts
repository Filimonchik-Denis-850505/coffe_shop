import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CatalogComponent } from './catalog.component';

const childRoutes = [
    { path: 'all', loadChildren: () => import('./all-products/all-products.module').then(m => m.AllProductsModule)},
    { path: 'coffe', loadChildren: () => import('./coffe-products/coffe-products.module').then(m => m.CoffeProductsModule)},
    { path: 'tea', loadChildren: () => import('./tea-products/tea-products.module').then(m => m.TeaProductsModule)}
]

const routes: Routes = [
    { path: '', component: CatalogComponent, redirectTo: 'all', pathMatch: 'full'},
    { path: '', component: CatalogComponent, children: childRoutes}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CatalogRoutingModule { }
