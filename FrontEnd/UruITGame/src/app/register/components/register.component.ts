import { Component, OnInit , Input, Output, EventEmitter,NgModule  } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs/Observable';
import { User } from '../models/User.Model';
import { State } from './../stores/reducers/register.reducer';
import { ActivatedRoute } from '@angular/router';
import * as usersActions from '../stores/actions/register.actions';

@Component({
  selector: 'app-user-register-container',
  templateUrl: './register.component.html'
})
export class RegisterComponent implements OnInit {
  player1Model: User;
  player2Model: User;
  @Input() users: User[];
  player1:string = "";
  player2:string = "";

  contactsTrackByFn = (index: number, users: User, ) => users.Id;
  constructor(private route : ActivatedRoute,
    private store: Store<State>) {

  }

  ngOnInit() {
    this.player1Model = { Name : "", Id:0};
    this.player2Model = { Name : "", Id:0};
  }

  
  startGame():void{
    console.log(this.player1)
    console.log(this.player2)
   
    console.log(this.player1Model);
    this.store.dispatch(new usersActions.Add(this.player1Model));
  }

}
