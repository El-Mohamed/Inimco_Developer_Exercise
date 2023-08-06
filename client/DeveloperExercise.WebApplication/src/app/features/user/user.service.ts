import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/app/enviroment';
import { Observable } from 'rxjs';
import { UserCalculations } from './models/user-calculations.model';
import { SaveUserResponse } from './models/save-user-response.model';
import { User } from './models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient: HttpClient) { }

  getUserCalculations(): Observable<UserCalculations> {
    return this.httpClient.get<UserCalculations>(environment.apiUrl + "/api/Person");
  }

  saveUser(user: User): Observable<SaveUserResponse> {
    return this.httpClient.post<SaveUserResponse>(environment.apiUrl + "/api/Person", user);
  }
}
