import { Action, Selector, State, StateContext } from '@ngxs/store';
import { Injectable } from '@angular/core';
import { tap } from 'rxjs';
import { UserStateModel } from './user-state.model';
import { UserService } from '../user.service';
import { GetUserCalculationAction, SaveUserAction } from './user.actions';

@State<UserStateModel>({ name: 'userstate' })
@Injectable()
export class UserState {

    @Selector() static userCalculations(state: UserStateModel) {
        return state.userCalculations;
    }

    @Selector() static userData(state: UserStateModel) {
        return state.userData;
    }

    constructor(private userService: UserService) { }

    @Action(GetUserCalculationAction)
    getUserInvite(ctx: StateContext<UserStateModel>, action: GetUserCalculationAction) {
        console.log(action)
        return this.userService.getUserCalculations().pipe(
            tap(userCalcs => {
                ctx.patchState({ userCalculations: userCalcs })
            }))
    }

    @Action(SaveUserAction)
    saveUser(ctx: StateContext<SaveUserAction>, action: SaveUserAction) {
        console.log(action)
        return this.userService.saveUser(action.user).pipe(
            tap(() => {
                ctx.patchState({ user: action.user })
                ctx.dispatch(new GetUserCalculationAction())
            }))
    }
}
