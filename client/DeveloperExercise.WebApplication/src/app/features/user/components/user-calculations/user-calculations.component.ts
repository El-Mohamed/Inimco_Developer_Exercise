import { Component } from '@angular/core';
import { UserState } from '../../state/user.state';
import { UserCalculations } from '../../models/user-calculations.model';
import { Select } from '@ngxs/store';
import { Observable } from 'rxjs';
import { User } from '../../models/user.model';

@Component({
  selector: 'app-user-calculations',
  templateUrl: './user-calculations.component.html',
  styleUrls: ['./user-calculations.component.scss']
})
export class UserCalculationsComponent {
  @Select(UserState.userCalculations) userCalculations$?: Observable<UserCalculations>;
  @Select(UserState.userData) user$?: Observable<User>;

}
