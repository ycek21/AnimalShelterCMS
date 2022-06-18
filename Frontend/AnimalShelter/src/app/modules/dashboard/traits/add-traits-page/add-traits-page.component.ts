import { HttpErrorResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { TraitsService } from '../../services/traitsService/traits.service';

@Component({
  selector: 'app-add-traits-page',
  templateUrl: './add-traits-page.component.html',
  styleUrls: ['./add-traits-page.component.scss'],
})
export class AddTraitsPageComponent implements OnInit {
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
  }
  addNewTrait(trait: string) {
    this.traitsService.postNewTrait(this.type, trait).subscribe(
      (resp) => {
        this.router.navigateByUrl(`/dashboard/traits/${this.type}`);
      },
      (error: HttpErrorResponse) => {
        alert(error.error);
      }
    );
  }
}
