import { environment } from 'src/environments/environment';

export const BASE_URL = environment.baseUrl + '/api/';

export const LOGIN_URL = BASE_URL + `authentication/login`;
export const REGISTER_URL = BASE_URL + 'authentication/register';
export const ANIMALS_URL = BASE_URL + `animals`;
export const CONFIGS_URL = BASE_URL + `configs`;
export const USERS_URL = BASE_URL + 'users';
export const CONFIG_URL = BASE_URL + 'configs';
