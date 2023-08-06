import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent {

  public userForm = this.formBuilder.group({
    firstName: ['', Validators.required],
    lastName:  ['', Validators.required],
    socialSkills:  ['', Validators.required],
  })

  /**
   *
   */
  constructor(private formBuilder: FormBuilder) {
    
    
  }
}
