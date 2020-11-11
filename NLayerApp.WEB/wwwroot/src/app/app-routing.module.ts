import  {NgModule} from "@angular/core";
import {RouterModule,Routes} from "@angular/router";

const routes: Routes =[
  { path: 'home', loadChildren: () => import('./home/home.module').then(m => m.HomeModule) },
  { path: '',redirectTo: 'home/main', pathMatch:'full'},
  { path: 'teaProducts', loadChildren: () => import('./home/catalog/tea-products/tea-products.module').then(m => m.TeaProductsModule) },
  { path: 'coffeProducts', loadChildren: () => import('./home/catalog/coffe-products/coffe-products.module').then(m => m.CoffeProductsModule) },
];

@NgModule({
  imports:[RouterModule.forRoot(routes)],
  exports:[RouterModule]
})
export class AppRoutingModule { }