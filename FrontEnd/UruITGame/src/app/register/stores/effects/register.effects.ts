import {Injectable} from '@angular/core';
import {Observable} from 'rxjs/Observable';
import { ofType } from '@ngrx/effects';
import {Action} from '@ngrx/store';
import * as userActions from './../actions/register.actions';
import {Actions, Effect} from '@ngrx/effects';
import { UserService } from '../../services/register.service';
import { User } from '../../models/User.Model';
import 'rxjs/Rx';
import { throwError } from 'rxjs';


@Injectable()
export class UserEffects {
    constructor(private actions$: Actions,private userService: UserService) {}
    
    @Effect()
    loadAll$: Observable<Action> = this.actions$.pipe(
        ofType(userActions.LOAD_ALL))     
        .startWith(new userActions.LoadAll())
        .switchMap(() =>
            this.userService.index() 
                .map((users: User[]) => new userActions.LoadAllSuccess(users))
        );
        
        @Effect()
        add$: Observable<Action> = this.actions$.pipe(
            ofType(userActions.ADD))  
            .map((action: userActions.Add) => action.payload)
            .switchMap((userAdd) =>
                this.userService.add(userAdd)
                    .map( (createdUser: User) => new userActions.AddSuccess(createdUser))
                    .catch(err => {
                        return throwError(new userActions.Failure({concern: 'CREATE', error: err}));
                    })
            );   

}
