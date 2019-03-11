import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { routes } from './routes';
import { AppComponent } from './app.component';
import { Store, StoreModule } from '@ngrx/store';
import {EffectsModule} from '@ngrx/effects';
import * as fromRoot from './store/reducers/index.reducers';
import { UserService } from './register/services/register.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { environment } from '../environments/environment';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(
      routes,
      { enableTracing: true } // <-- debugging purposes only
    ),
    StoreModule.forRoot(fromRoot.rootReducer),    
    StoreDevtoolsModule.instrument({ maxAge: 50 }),
    EffectsModule.forRoot([]) /* Start monitoring app's side effects */    
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
