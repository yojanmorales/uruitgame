import { Injectable } from '@angular/core';
import { Store, Action } from '@ngrx/store';
import { User } from '../../models/User.Model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import 'rxjs/add/operator/toPromise';
import {Update} from '@ngrx/entity/src/models';

/*
  ACTION CONSTANTS
*/


export const LOAD_ALL = '[User] LOAD ALL';
export const LOAD_ALL_SUCCESS = '[User] LOAD ALL SUCCESS';

export const FAILURE = '[User] FAILURE';

export const ADD = '[User] ADD';
export const ADD_SUCCESS = '[User] ADD SUCCESS';
/*
  ACTION CLASSES
*/

export class LoadAll implements Action {
  readonly type = LOAD_ALL;
  
  constructor(public payload = null) {}
}
export class LoadAllSuccess implements Action {
  readonly type = LOAD_ALL_SUCCESS;
  
  constructor(public payload: User[]) {}
}
export class Add implements Action {
  readonly type = ADD;
  constructor(public payload: User) {}
}

export class AddSuccess implements Action {
  readonly type = ADD_SUCCESS;
  constructor(public payload: User) {}
}
export class Failure implements Action {
  readonly type = FAILURE;
  constructor (public payload: {concern: 'CREATE' | 'PATCH', error: any}) {}
}

export type All =
| LoadAll
| Failure
| LoadAllSuccess
| Add
| AddSuccess
