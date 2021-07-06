import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EngineService } from '../engine.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  tickets = null;
  username: string = '';

  constructor(private engineservice: EngineService, private route: Router) { }

  ngOnInIt() {
    this.engineservice.getAllTickets(tickets => {
      this.tickets = tickets.result;
      console.log(this.tickets);
    });
  }
 
  clickLogin() {
    this.engineservice.username = this.username;
  }

  
}
