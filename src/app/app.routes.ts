import { Routes } from '@angular/router';
import { EventListComponent } from './pages/event-list/event-list.component';
import { AddEventComponent } from './pages/add-event/add-event.component';
import { EditEventComponent } from './pages/edit-event/edit-event.component';

export const routes: Routes = [
  { path: '', redirectTo: '/event-list', pathMatch: 'full' },
  { path: 'event-list', component: EventListComponent },
  { path: 'add-event', component: AddEventComponent },
  { path: 'edit-event/:id', component: EditEventComponent }
];