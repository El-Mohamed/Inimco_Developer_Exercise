import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { CoreModule } from './core/core.module';
import { NgxsModule } from '@ngxs/store';
import { UserState } from './features/user/state/user.state';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CoreModule,
    NgxsModule.forRoot([UserState], {
      developmentMode: true
    }),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
