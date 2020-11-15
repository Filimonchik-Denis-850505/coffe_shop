import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';



const routes: Routes = [
    { path: 'catalog', loadChildren: () => import('./catalog/catalog.module').then(m => m.CatalogModule) },
    { path: 'main', loadChildren: () => import('./main/main.module').then(m => m.MainModule) },
    { path: 'basket', loadChildren: () => import('./basket/basket.module').then(m => m.BasketModule) },
    { path: '', redirectTo: 'main', pathMatch: 'full'}
 ];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
