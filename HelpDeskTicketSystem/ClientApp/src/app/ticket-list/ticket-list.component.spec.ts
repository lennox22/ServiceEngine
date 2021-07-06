/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { TicketListComponent } from './ticket-list.component';

let component: TicketListComponent;
let fixture: ComponentFixture<TicketListComponent>;

describe('ticket-list component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ TicketListComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(TicketListComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});