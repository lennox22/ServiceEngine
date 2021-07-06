import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { EngineService } from '../engine.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private engineservice: EngineService, private route: Router) { }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logout() {
    this.engineservice.username = null;
    this.route.navigateByUrl('/');
  }
}
