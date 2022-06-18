/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { WalkService } from './walk.service';

describe('Service: Walk', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WalkService]
    });
  });

  it('should ...', inject([WalkService], (service: WalkService) => {
    expect(service).toBeTruthy();
  }));
});
