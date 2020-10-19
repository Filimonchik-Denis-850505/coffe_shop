import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import {HttpClient, HttpClientModule} from "@angular/common/http";


import {AppComponent} from './app.component';
import {FooterComponent} from "./footer/footer.component";
import {HeaderComponent} from "./header/header.component";

import {AppRoutingModule} from './app-routing.module';
import {HomeComponent} from "./home/home.component";


@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        AppRoutingModule,

    ],
    declarations: [
        AppComponent,
        HeaderComponent,
        FooterComponent,
        HomeComponent
    ],
    bootstrap: [
        AppComponent
    ],
    providers: [
        HttpClient
    ]
})
export class AppModule {
}