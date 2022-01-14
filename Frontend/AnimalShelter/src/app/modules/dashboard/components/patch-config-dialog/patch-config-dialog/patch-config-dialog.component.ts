import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-patch-config-dialog',
  templateUrl: './patch-config-dialog.component.html',
  styleUrls: ['./patch-config-dialog.component.scss'],
})
export class PatchConfigDialogComponent implements OnInit {
  form: FormGroup = this.fb.group({
    newConfigValue: ['', Validators.required],
  });

  constructor(
    public dialogRef: MatDialogRef<PatchConfigDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public configKey: string,
    private fb: FormBuilder
  ) {}

  ngOnInit() {}

  public onSave() {
    const formValue = this.form.get('newConfigValue').value;
    const configToChange = { key: this.configKey, value: formValue };
    this.dialogRef.close(configToChange);
  }

  public onClose() {
    this.dialogRef.close();
  }
}
