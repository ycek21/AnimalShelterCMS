import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-traits-form',
  templateUrl: './traits-form.component.html',
  styleUrls: ['./traits-form.component.scss'],
})
export class TraitsFormComponent implements OnInit {
  @Input() type: string;
  @Output() addNewTrait = new EventEmitter<string>();
  trait: string = '';

  constructor() {}

  ngOnInit() {}

  addTrait() {
    this.addNewTrait.emit(this.trait);
  }
}
