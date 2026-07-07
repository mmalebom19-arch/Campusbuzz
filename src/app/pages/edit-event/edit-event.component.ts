import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EventDataService } from '../../services/event-data.service';
import { Event } from '../../event-model';

@Component({
  selector: 'app-edit-event',
  imports: [RouterModule, FormsModule, CommonModule],
  templateUrl: './edit-event.component.html',
  styleUrl: './edit-event.component.css'
})
export class EditEventComponent implements OnInit {

  event: Event = { id: 0, eventTitle: '', location: '', ticketPrice: '' };

  constructor(
    private eventService: EventDataService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.eventService.getEventById(Number(id)).subscribe(data => {
      this.event = data;
    });
  }

  saveChanges(): void {
    this.eventService.editEvent(this.event.id, this.event).subscribe(() => {
      this.router.navigate(['/event-list']);
    });
  }

  cancel(): void {
    this.router.navigate(['/event-list']);
  }
}