import { Component } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Select, Store } from '@ngxs/store';
import { UserState } from '../../state/user.state';
import { Observable } from 'rxjs';
import { User } from '../../models/user.model';
import { SaveUserAction } from '../../state/user.actions';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent {

  @Select(UserState.userData) userData$?: Observable<User>;

  public userForm = this.formBuilder.group({
    id: ['', Validators.required],
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    socialSkills: this.formBuilder.array([], Validators.required),
    socialAccounts: this.formBuilder.array([]),
  });

  constructor(private formBuilder: FormBuilder, private store: Store) {
  }

  saveUser() {
    const user = this.userForm.value as User;
    this.store.dispatch(new SaveUserAction(user))
  }

  createSocialSkill(): FormGroup {
    return this.formBuilder.group({
      skill: ['', Validators.required]
    });
  }

  // Social Accounts FormArray
  get socialAccountsFormArray(): FormArray {
    return this.userForm.get('socialAccounts') as FormArray;
  }

  get socialSkillsFormArray(): FormArray {
    return this.userForm.get('socialSkills') as FormArray;
  }

  createSocialAccount(): FormGroup {
    return this.formBuilder.group({
      type: ['', Validators.required],
      address: ['', Validators.required]
    });
  }

  addSocialSkill(): void {
    const socialSkills = this.userForm.get('socialSkills') as FormArray;
    socialSkills.push(this.createSocialSkill());
  }

  removeSocialSkill(index: number): void {
    const socialSkills = this.userForm.get('socialSkills') as FormArray;
    socialSkills.removeAt(index);
  }

  addSocialAccount(): void {
    const socialAccounts = this.userForm.get('socialAccounts') as FormArray;
    socialAccounts.push(this.createSocialAccount());
  }

  removeSocialAccount(index: number): void {
    const socialAccounts = this.userForm.get('socialAccounts') as FormArray;
    socialAccounts.removeAt(index);
  }
}
