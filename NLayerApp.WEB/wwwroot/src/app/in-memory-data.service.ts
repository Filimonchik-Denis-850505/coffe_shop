import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import {Product} from "./product";


@Injectable({
  providedIn: 'root',
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const products = [
      { id: 1, name: 'Lipton', description: "Cool tea!", price: "879" },
      { id: 2, name: 'Narco' ,description: "Cool tea!", price: "879"},
      { id: 3, name: 'Bombasto',description: "Cool tea!" , price: "879"},
      { id: 4, name: 'Celeritas',description: "Cool tea!" , price: "879"},
      { id: 5, name: 'Magneta',description: "Cool tea!" , price: "879"},
      { id: 6, name: 'RubberMan',description: "Cool tea!" , price: "879"},
      { id: 7, name: 'Dynama',description: "Cool tea!" , price: "879"},
      { id: 8, name: 'Dr IQ' ,description: "Cool tea!", price: "879"},
      { id: 9, name: 'Magma' ,description: "Cool tea!", price: "879"},
      { id: 10, name: 'Tornado' ,description: "Cool tea!", price: "879"}
    ];
    return {products};
  }

  // Overrides the genId method to ensure that a hero always has an id.
  // If the heroes array is empty,
  // the method below returns the initial number (11).
  // if the heroes array is not empty, the method below returns the highest
  // hero id + 1.
  genId(products: Product[]): number {
    return products.length > 0 ? Math.max(...products.map(hero => hero.productTypeId)) + 1 : 1;
  }
}