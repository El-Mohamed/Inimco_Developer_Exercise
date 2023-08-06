import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppRoutes } from './app.routes';

const routes: Routes = [
  // TODO NOT FOUND ROUTE
  // TODO DEFAULT ROUTE
  {
    path: AppRoutes.User,
    loadChildren: () => import('./features/user/user.module').then((m) => m.UserModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
