import { Routes, RouterModule } from '@angular/router';
import { UserRoutes } from './routes';
import { UserDetailsComponent } from './components/user-details/user-details.component';

const routes: Routes = [
  {
    path: UserRoutes.CreateUser,
    component: UserDetailsComponent,
    data: {
      title: 'home_component',
    },
  },
];

export const userRoutes = RouterModule.forChild(routes);