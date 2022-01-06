import { environment } from 'src/environments/environment';

export const BASE_URL = environment.baseUrl + '/api/';

export const LOGIN_URL = BASE_URL + `authentication/login`;
export const REGISTER_URL = BASE_URL + 'authentication/register';
export const ANIMALS_URL = BASE_URL + `animals`;
