import { Component } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngxs/store';
import { User } from '../../models/user.model';
import { SaveUserAction } from '../../state/user.actions';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent {

  public userForm = this.formBuilder.group({
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    socialSkills: this.formBuilder.array([]),
    socialAccounts: this.formBuilder.array([]),
  });

  constructor(private formBuilder: FormBuilder, private store: Store) {
  }

  saveUser() {
    if(this.userForm.invalid) return;
    
    const user = this.userForm.value as User;
    console.log(user)
    this.store.dispatch(new SaveUserAction(user))
  }

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

  addSocialAccount(): void {
    const socialAccounts = this.userForm.get('socialAccounts') as FormArray;
    socialAccounts.push(this.createSocialAccount());
  }

  removeSocialAccount(index: number): void {
    const socialAccounts = this.userForm.get('socialAccounts') as FormArray;
    socialAccounts.removeAt(index);
  }

  addSocialSkill(): void {
    const socialSkills = this.userForm.get('socialSkills') as FormArray;
    socialSkills.push(this.createSocialSkill(socialSkills.length));
  }

  createSocialSkill(controlName: number): FormControl {
    return this.formBuilder.control({
      [`${controlName}`]: [' ', Validators.required]
    });
  }

  removeSocialSkill(index: number): void {
    const socialSkills = this.userForm.get('socialSkills') as FormArray;
    socialSkills.removeAt(index);
  }
}



