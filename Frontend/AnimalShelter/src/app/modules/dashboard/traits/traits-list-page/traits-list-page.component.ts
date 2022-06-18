import { TraitsService } from '../../services/traitsService/traits.service';
import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { Trait } from '../../models/trait';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-traits-list-page',
  templateUrl: './traits-list-page.component.html',
  styleUrls: ['./traits-list-page.component.scss'],
})
export class TraitsListPageComponent implements OnInit {
  traits: Observable<Trait[]>;
  private sub: Subscription;
  type: string;

  constructor(
    private traitsService: TraitsService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.router.routeReuseStrategy.shouldReuseRoute = () => false;
  }

  ngOnInit() {
    this.sub = this.route.params.subscribe((params) => {
      this.type = params['id'];
    });
    this.getTraits(this.type);
  }

  private getTraits(traits: string): void {
    this.traits = this.traitsService.getAllTraits(traits);
  }
  ngOnDestroy() {
    this.sub.unsubscribe();
  }
}
