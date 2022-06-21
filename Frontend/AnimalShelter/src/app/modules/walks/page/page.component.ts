import { UserService } from './../../dashboard/services/userService/user.service';
import { WalkService } from './../services/walk.service';
import { Walk } from './../models/walk';
import { Component, OnInit } from '@angular/core';
import { Observable, tap, switchMap } from 'rxjs';

@Component({
  selector: 'app-page',
  templateUrl: './page.component.html',
  styleUrls: ['./page.component.scss'],
})
export class PageComponent implements OnInit {
  walks: Walk[];
  constructor(
    private walkService: WalkService,
    private userService: UserService
  ) {}

  ngOnInit() {
    this.getUserWithWalks();
  }

  getUserWithWalks() {
    this.userService
      .getUser(this.userService.userEmail)
      .pipe(
        switchMap((user) => {
          return this.getUserWalks(user.id);
        })
      )
      .subscribe((resp) => {
        this.walks = resp;
      });
  }
  getUserWalks(userId: string) {
    return this.walkService.getAllWalksForUser(userId);
  }
  deleteWalk(walkId: string) {
    this.walkService.deleteWalk(walkId).subscribe((resp) => {
      this.getUserWithWalks();
    });
  }
}
