import { User } from "../models/user.model";

export class GetUserCalculationAction {
    static readonly type = '[Users] Get Get User Calculation';
  
}

export class SaveUserAction {
    static readonly type = '[Users] Save User';
    constructor(public user: User) {}
}