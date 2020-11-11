import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";
import {CatalogService} from "./catalog.service";
import {Product} from "../../product";

@Component({
  selector: 'catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.scss']
})
export class CatalogComponent implements OnInit {
  navBar = ['все', 'чай', 'кофе', 'травы'];
  selectedId: string = this.navBar[0];
  
  constructor(private router:Router) { }
  
  ngOnInit(): void {
    //this.router.navigateByUrl("home/catalog/all");
  }
  
  onSwitchNavItem(item: string) {
    this.selectedId = item;
    if(this.selectedId == this.navBar[0]) this.router.navigateByUrl("home/catalog/all");
    if(this.selectedId == this.navBar[2]) this.router.navigateByUrl("home/catalog/coffe");
    if(this.selectedId == this.navBar[1]) this.router.navigateByUrl("home/catalog/tea");
  }
}
