import { Component, OnInit } from '@angular/core';
import { User } from './models/User.Model';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs/Observable';
//import * as fromProductos from './reducers/productos.reducer';
import {ActivatedRoute, Router} from '@angular/router';
import * as fromRegister from './stores/index';
import * as usersActions from './stores/actions/register.actions';
import * as fromRoot from './stores/reducers/register.reducer';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})
export class RegisterComponent implements OnInit {

  
  
  users$: Observable<User[]>;
  constructor(public store: Store<fromRoot.State>, private router: Router, 
    private actR: ActivatedRoute){}
  ngOnInit() {
   
     //this.users$ = this.store.select( fromRegister.getAllusers );
     
     //this.users$.subscribe(console.log);
     
    // this.store.dispatch(new usersActions.LoadAll());



  }
}
