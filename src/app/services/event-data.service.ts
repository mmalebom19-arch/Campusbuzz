import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Event } from '../event-model';

@Injectable({
  providedIn: 'root'
})
export class EventDataService {

  private apiUrl = 'https://localhost:7235/api/Events';

  constructor(private http: HttpClient) { }

  getAllEvents(): Observable<Event[]> {
    return this.http.get<Event[]>(this.apiUrl);
  }

  getEventById(id: number): Observable<Event> {
    return this.http.get<Event>(`${this.apiUrl}/${id}`);
  }

  addEvent(ev: Event): Observable<Event> {
    return this.http.post<Event>(this.apiUrl, ev);
  }

  editEvent(id: number, ev: Event): Observable<Event> {
    return this.http.put<Event>(`${this.apiUrl}/${id}`, ev);
  }

  deleteEvent(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}