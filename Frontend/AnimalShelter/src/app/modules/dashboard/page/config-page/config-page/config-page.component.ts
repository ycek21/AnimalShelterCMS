import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Config } from '../../../models/config';
import { ConfigService } from '../../../services/configService/config.service';

@Component({
  selector: 'app-config-page',
  templateUrl: './config-page.component.html',
  styleUrls: ['./config-page.component.scss'],
})
export class ConfigPageComponent implements OnInit {
  configs: Observable<Config[]>;

  constructor(private configService: ConfigService) {}

  ngOnInit() {
    this.getAllConfigs();
  }

  private getAllConfigs(): void {
    this.configs = this.configService.getAllConfigs();
  }

  public patchParticularConfig(config: { key: string; value: string }) {
    this.configService.patchConfig(config).subscribe(() => {
      this.getAllConfigs();
    });
  }
}
