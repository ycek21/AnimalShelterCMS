import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { AuthService } from '../../user/services/auth.service';
import { WalkForPost } from '../../walks/models/walkForPost';

@Component({
  selector: 'app-walk-calendar',
  templateUrl: './walk-calendar.component.html',
  styleUrls: ['./walk-calendar.component.scss'],
})
export class WalkCalendarComponent implements OnInit {
  constructor(public authService: AuthService) {}

  @Input() animalId: string = undefined;
  @Output() postWalkEmitter: EventEmitter<WalkForPost> = new EventEmitter();

  selectedDate: Date = new Date();

  selectedTimeControl: FormControl = new FormControl(null, Validators.required);

  timeOptions: string[] = ['10:00', '11:00', '12:00'];

  ngOnInit() {
    this.listenToTimeChange();
  }

  public resetTimeControl(): void {
    this.selectedTimeControl.reset();
  }

  public postWalk() {
    const walkForPost: WalkForPost = {
      AnimalId: this.animalId,
      DateOfWalk: this.selectedDate,
    };

    this.postWalkEmitter.emit(walkForPost);
  }

  public setTimeOnCalendarChange(event: any) {
    if (this.selectedTimeControl.value !== null) {
      this.setTime();
    }
  }

  private listenToTimeChange(): void {
    this.selectedTimeControl.valueChanges.subscribe((value: string) => {
      if (this.selectedTimeControl.value !== null) {
        this.setTime();
      }
    });
  }

  private setTime(): void {
    const splittedValue: string[] = this.selectedTimeControl.value.split(':');
    this.selectedDate.setHours(
      Number(splittedValue[0]),
      Number(splittedValue[1])
    );
    this.selectedDate = new Date(this.selectedDate);
  }
}
