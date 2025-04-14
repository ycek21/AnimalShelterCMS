import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../../models/user';

@Component({
  selector: 'app-user-table',
  templateUrl: './user-table.component.html',
  styleUrls: ['./user-table.component.scss'],
})
export class UserTableComponent implements OnInit {
  @Input() users: Observable<User[]>;
  @Input() userEmail: string;

  @Output() userToDelete = new EventEmitter<User>();
  @Output() userToChangeTheRole = new EventEmitter<User>();

  displayedColumns: string[] = [
    'name',
    'surname',
    'email',
    'dateOfBirth',
    'roles',
    'actions',
  ];

  constructor() {}

  ngOnInit() {}

  public deleteUser(user: User) {
    this.userToDelete.emit(user);
  }

  public changeUserRole(user: User) {
    this.userToChangeTheRole.emit(user);
  }
}
