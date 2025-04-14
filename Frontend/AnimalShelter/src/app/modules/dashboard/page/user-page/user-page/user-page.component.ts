import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../../../models/user';
import { UserService } from '../../../services/userService/user.service';

@Component({
  selector: 'app-user-page',
  templateUrl: './user-page.component.html',
  styleUrls: ['./user-page.component.scss'],
})
export class UserPageComponent implements OnInit {
  users: Observable<User[]>;
  userEmail: string;

  constructor(private userService: UserService) {}

  ngOnInit() {
    this.getUsers();
    this.getUserEmail();
  }

  private getUsers(): void {
    this.users = this.userService.getAllUsers();
  }

  public deleteUser(user: User): void {
    const userId = user.id;

    this.userService.deleteUser(userId).subscribe(() => {
      this.getUsers();
    });
  }

  public changeRole(user: User) {
    this.userService.changeRole(user).subscribe(() => {
      this.getUsers();
    });
  }

  private getUserEmail() {
    this.userEmail = this.userService.userEmail;
  }
}
