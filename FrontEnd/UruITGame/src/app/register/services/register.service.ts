import { Injectable } from '@angular/core';
import {HttpClient, HttpParams} from '@angular/common/http';
import {Observable} from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { User } from '../models/User.Model';

@Injectable()
export class UserService {

    constructor(private http: HttpClient ) { }
  
  
    index(): Observable<any> {
      return this.http.get<User[]>(`https://localhost:44322/odata/Users`).map((response: any) => {
        return response.value;
    }).catch((error) => {
      return Observable.throw(error);
      });
    } 
    add(user: User): Observable<User> {
      return this.http.post<User>(`https://localhost:44322/odata/Users`, user)
    }
    
}
