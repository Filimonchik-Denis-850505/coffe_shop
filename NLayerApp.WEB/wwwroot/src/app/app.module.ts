import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {FormsModule} from '@angular/forms';
import {AppComponent} from './app.component';
import {HttpClient, HttpClientModule} from "@angular/common/http";;
import { HeaderComponent } from './Header/header/header.component';
import { FooterComponent } from './Footer/footer/footer.component'

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule
    ],
    declarations: [
        AppComponent,
        HeaderComponent,
        FooterComponent
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