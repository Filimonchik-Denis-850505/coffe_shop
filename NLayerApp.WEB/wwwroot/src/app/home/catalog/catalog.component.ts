import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.scss']
})
export class CatalogComponent implements OnInit {
  navBar = ['все', 'чай', 'кофе', 'травы'];
  selectedId: string = this.navBar[0];

  tmpTitle = ['Name1', 'Name2','Name3','Name4','Name5', 'Name6','Name7','Name8'];
  description: string = "dks hfkjsdh fjkhsdkj fhksdhfkj hsd kjfhk jsdhfk jhsd kjfhkj sdhf kjhsdk jfh";

  constructor() { }

  ngOnInit(): void {
  }

  onSwitchNavItem(item: string){
    this.selectedId = item;
  }
}
