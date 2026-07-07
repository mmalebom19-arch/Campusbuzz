import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { EventDataService } from '../../services/event-data.service';
import { Event } from '../../event-model';

@Component({
  selector: 'app-event-list',
  imports: [RouterModule, CommonModule],
  templateUrl: './event-list.component.html',
  styleUrl: './event-list.component.css'
})
export class EventListComponent implements OnInit {

  events: Event[] = [];

  constructor(private eventService: EventDataService) {}

  ngOnInit(): void {
    this.loadEvents();
  }

  loadEvents(): void {
    this.eventService.getAllEvents().subscribe(data => {
      this.events = data;
    });
  }

  deleteEvent(id: number): void {
    this.eventService.deleteEvent(id).subscribe(() => {
      this.loadEvents();
    });
  }
}