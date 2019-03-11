import { User } from '../../models/User.Model';
import {EntityState, createEntityAdapter} from '@ngrx/entity';
import * as registerActions from '../actions/register.actions';
import {Update} from '@ngrx/entity/src/models';


export const usersAdapter = createEntityAdapter<User>({
    selectId: (user: User) => user.Id,
    sortComparer: false
  });
  
  export interface State extends EntityState<User> {
    currentUserId?: number
  }
  
  export const INIT_STATE: State = usersAdapter.getInitialState({
    currentUserId: undefined
  });
  
  
  
  export function reducer(state: State = INIT_STATE,{type, payload}: registerActions.All){
  
    switch (type) {  
  
      case registerActions.LOAD_ALL_SUCCESS : {
  
        return {...state, ...usersAdapter.addAll(payload as User[], state)}
      }

      case registerActions.ADD_SUCCESS : {
        return {...state, ...usersAdapter.addOne(payload as User, state)}
      }
  
      
      default: {
        return state;
      }
  
    }
  }
  
  export const getCurrentUserId = (state: State) => state.currentUserId;
 