import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.scss']
})
export class CatalogComponent implements OnInit {
  navBar = ['все', 'чай', 'кофе', 'травы'];
  selectedId: string = this.navBar[0];

  constructor() { }

  ngOnInit(): void {
  }

  onSwitchNavItem(item: string){
    this.selectedId = item;
  }
}
