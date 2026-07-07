import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EventDataService } from '../../services/event-data.service';
import { Event } from '../../event-model';

@Component({
  selector: 'app-add-event',
  imports: [RouterModule, FormsModule, CommonModule],
  templateUrl: './add-event.component.html',
  styleUrl: './add-event.component.css'
})
export class AddEventComponent {

  event: Event = { id: 0, eventTitle: '', location: '', ticketPrice: '' };

  constructor(
    private eventService: EventDataService,
    private router: Router
  ) {}

  submitEvent(): void {
    this.eventService.addEvent(this.event).subscribe(() => {
      this.router.navigate(['/event-list']);
    });
  }

  cancel(): void {
    this.router.navigate(['/event-list']);
  }

  isFormValid(): boolean {
    return this.event.eventTitle !== '' &&
           this.event.location !== '' &&
           this.event.ticketPrice !== '';
  }
}