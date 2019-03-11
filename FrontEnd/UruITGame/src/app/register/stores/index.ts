import * as fromRegister from './reducers/register.reducer'
import * as fromRoot from '../stores/reducers/register.reducer';
import {createFeatureSelector, createSelector} from '@ngrx/store';

export interface UsersState {
  users: fromRegister.State
}

// This is a lazy loaded state, so we need to extend from the App Root State
export interface State extends fromRoot.State {
  users: UsersState
}

export const reducers = {
  users: fromRegister.reducer
};

export const getusersRootState = createFeatureSelector<UsersState>('users');

export const getUsersState = createSelector(
    getusersRootState,
    state => state.users
);

export const getSelectedusersId = createSelector(
    getUsersState,
  fromRegister.getCurrentUserId
);

export const {
  selectAll: getAllusers,
  selectEntities: getusersEntities
} = fromRegister.usersAdapter.getSelectors(getUsersState);

export const getCurrentContact = createSelector(
  getusersEntities,
  getSelectedusersId,
  (entities, id) => id && entities[id]
);
