import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './components/register.component';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Store, StoreModule } from '@ngrx/store';
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import {EffectsModule} from '@ngrx/effects';
import * as fromRegister from './stores';
import { UserEffects } from './stores/effects/register.effects';

@NgModule({
  imports: [
    FormsModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule.forChild([
      {
        path: ':register/',
        component: RegisterComponent,
      },
      { path: '', component: RegisterComponent },
    ]),
    StoreModule.forFeature('register', fromRegister.reducers),
    EffectsModule.forFeature([UserEffects])
  ],
  declarations: [RegisterComponent]
})
export class RegisterModule { }
