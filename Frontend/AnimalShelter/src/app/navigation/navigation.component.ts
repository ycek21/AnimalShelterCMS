import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { filter, map, shareReplay } from 'rxjs/operators';
import { NavigationEnd, Router } from '@angular/router';
import { AuthService } from '../modules/user/services/auth.service';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.scss'],
})
export class NavigationComponent implements OnInit {
  isHandset$: Observable<boolean> = this.breakpointObserver
    .observe(Breakpoints.Handset)
    .pipe(
      map((result) => result.matches),
      shareReplay()
    );
  subTitle: string = '';
  subHeader: boolean = true;
  constructor(
    private breakpointObserver: BreakpointObserver,
    private router: Router,
    private authService: AuthService
  ) {
    router.events
      .pipe(filter((event) => event instanceof NavigationEnd))
      .subscribe((event) => {
        if (event instanceof NavigationEnd) {
          switch (event.url) {
            case '/home': {
              this.subTitle = 'Home';
              break;
            }
            case '/about': {
              this.subTitle = 'About us';
              break;
            }
            case '/adoptions': {
              this.subTitle = 'Adoptions';
              break;
            }
            case '/fundraisers': {
              this.subTitle = 'Fundraisers';
              break;
            }
            case '/user': {
              this.subTitle = 'Users';
              break;
            }
            case '/animals': {
              this.subTitle = 'Animals';
              break;
            }
            case event.url.match('/animals/')?.input: {
              this.subTitle = 'Animals';
              break;
            }
            case '/dashboard': {
              this.subTitle = 'Dashboard ';
              break;
            }
            case event.url.match('/dashboard/')?.input: {
              this.subTitle = 'Dashboard ';
              break;
            }
          }
        }
      });
  }

  ngOnInit() {}

  getUserRole() {
    return localStorage.getItem('userRole');
  }
  logOut() {
    this.authService.setLogged(false);
  }
}
