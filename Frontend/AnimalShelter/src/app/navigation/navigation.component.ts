import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { filter, map, shareReplay } from 'rxjs/operators';
import { NavigationEnd, Router } from '@angular/router';

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
  constructor(
    private breakpointObserver: BreakpointObserver,
    private router: Router
  ) {
    router.events
      .pipe(filter((event) => event instanceof NavigationEnd))
      .subscribe((event) => {
        if (event instanceof NavigationEnd) {
          console.log(event.url);
          switch (event.url) {
            case '/home': {
              this.subTitle = 'Home';
              break;
            }
            case '/about': {
              this.subTitle = 'About';
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
          }
        }
      });
  }

  ngOnInit() {}
}
