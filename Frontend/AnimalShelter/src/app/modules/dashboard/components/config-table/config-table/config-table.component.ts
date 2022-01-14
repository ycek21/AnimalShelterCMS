import {
  Component,
  EventEmitter,
  Input,
  OnDestroy,
  OnInit,
  Output,
} from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable, Subscription } from 'rxjs';
import { Config } from '../../../models/config';
import { PatchConfigDialogComponent } from '../../patch-config-dialog/patch-config-dialog/patch-config-dialog.component';

@Component({
  selector: 'app-config-table',
  templateUrl: './config-table.component.html',
  styleUrls: ['./config-table.component.scss'],
})
export class ConfigTableComponent implements OnInit, OnDestroy {
  @Input() configs: Observable<Config[]>;
  @Output() configToPatch: EventEmitter<{ key: string; value: string }> =
    new EventEmitter<{
      key: string;
      value: string;
    }>();
  dialogSubscription: Subscription = new Subscription();
  constructor(public dialog: MatDialog) {}

  displayedColumns: string[] = [
    'key',
    'value',
    'modifiedBy',
    'modifiedAt',
    'actions',
  ];

  ngOnInit() {}

  public openPatchConfigDialog(config: Config) {
    const dialogConfig = { width: '450px', data: config.key };

    const dialogRef = this.dialog.open(
      PatchConfigDialogComponent,
      dialogConfig
    );

    this.dialogSubscription = dialogRef
      .afterClosed()
      .subscribe((valueToPatch) => {
        this.configToPatch.emit(valueToPatch);
      });
  }

  ngOnDestroy(): void {
    this.dialogSubscription.unsubscribe();
  }
}
