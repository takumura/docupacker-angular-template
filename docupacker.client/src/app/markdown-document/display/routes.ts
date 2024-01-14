import { Route } from '@angular/router';
import { DisplayComponent } from './display.component';

export default [
  {
    path: '',
    children: [
      {
        path: '**',
        component: DisplayComponent,
      },
    ],
  },
] as Route[];
