import { Component } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { AlertComponent } from '../shared/components/presentational/alert/alert.component';

@Component({
  selector: 'app-color-check',
  standalone: true,
  imports: [MatButtonModule, AlertComponent],
  templateUrl: './color-check.component.html',
  styleUrls: ['./color-check.component.scss'],
})
export class ColorCheckComponent {}
