import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../../models/user';
import { UserRole } from '../../models/user-role.enum';
import { USERS_URL } from './../../../../shared/consts';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private _userEmail: string = this.getUserEmail();

  constructor(private http: HttpClient) {}

  public get userEmail(): string {
    return this._userEmail;
  }

  public getAllUsers(): Observable<User[]> {
    const url = USERS_URL;

    return this.http.get<User[]>(url);
  }

  public deleteUser(userId: string) {
    const url = USERS_URL + '/' + userId;
    return this.http.delete(url);
  }

  public changeRole(user: User) {
    let roleToGrant: string = '';
    if (user.roles[0] === 'CommonUser') {
      roleToGrant = UserRole.Administrator;
    } else {
      roleToGrant = UserRole.CommonUser;
    }

    const url = USERS_URL + '/' + user.id;

    const body = { role: roleToGrant };

    return this.http.patch(url, body);
  }

  private getUserEmail() {
    return localStorage.getItem('userEmail');
  }
  public getUser(email: string): Observable<User> {
    const url = USERS_URL + `/${email}`;
    return this.http.get<User>(url);
  }
}
