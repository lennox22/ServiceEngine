import { Component } from '@angular/core';
import { EngineService } from '../engine.service';

@Component({
    selector: 'app-ticket-list',
    templateUrl: './ticket-list.component.html',
    styleUrls: ['./ticket-list.component.css']
})
/** ticket-list component*/
export class TicketListComponent {
  /** ticket-list ctor */

  tickets = null;
  itemno: number = 1;

  engineservice: EngineService = null;
  constructor(ticketengine: EngineService) {
    this.engineservice = ticketengine;
  }

  ngOnInIt() {
    this.engineservice.getAllTickets(tickets => {
      this.tickets = tickets.result;
      console.log(this.tickets);
    });
  }

  showdetail() {
    this.engineservice.getAllTickets(ticketresult => {
      console.log(ticketresult);
      this.tickets = ticketresult;
      this.itemno = 1;
    })
  }

  showcount() {
    this.itemno++;
  }
}
