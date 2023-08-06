import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserDetailsComponent } from './components/user-details/user-details.component';
import { userRoutes } from './user.routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UserCalculationsComponent } from './components/user-calculations/user-calculations.component';
import { CoreModule } from 'src/app/core/core.module';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [
    UserDetailsComponent,
    UserCalculationsComponent
  ],
  imports: [
    CommonModule,
    userRoutes,
    FormsModule,
    ReactiveFormsModule,
    CoreModule,
    SharedModule
  ]
})
export class UserModule { }
