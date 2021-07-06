import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class EngineService {
  username: string = null;
  constructor(private http: HttpClient) {

  }
  getAllTickets(cb) {
    this.http.get<any>('/ticket/all').subscribe(tickets => {
      cb(tickets);
    });
  }

  getBookmarksByUser(cb) {
    this.http.get<any>(`/bookmark/by/${this.username}`).subscribe(tickets => {
      cb(tickets);
    });
  }

  addNewTicket() { }

  addBookmark() { }

  closeTicket() { }

  deleteBookmark() { }

  deleteTicket() { }
}
