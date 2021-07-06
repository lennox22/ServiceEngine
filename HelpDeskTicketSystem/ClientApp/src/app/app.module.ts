import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { EngineService } from './engine.service';
import { TicketListComponent } from './ticket-list/ticket-list.component';


@NgModule({
	declarations: [
		AppComponent,
		NavMenuComponent,
    HomeComponent,
    TicketListComponent,
	],
	imports: [
		BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
		HttpClientModule,
		FormsModule,
		RouterModule.forRoot([
			{ path: '', component: HomeComponent, pathMatch: 'full' },
		])
  ],
  providers: [EngineService],
	bootstrap: [AppComponent]
})
export class AppModule { }
