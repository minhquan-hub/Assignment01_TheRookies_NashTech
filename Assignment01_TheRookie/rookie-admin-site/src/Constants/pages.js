export const LOGIN = '/login';
export const AUTH = '/authentication/:action';
export const HOME = '/';

// Product
export const PRODUCT = '/product';
export const CREATE_PRODUCT = '/product/create';
export const EDIT_PRODUCT = '/product/edit/:id';
export const EDIT_PRODUCT_ID = (id) => `/product/edit/${id}`;

// Category 
export const CATEGORY = '/category';
export const CREATE_CATEGORY = '/category/create';
export const EDIT_CATEGORY = '/category/edit/:id';
export const EDIT_CATEGORY_ID = (id) => `/category/edit/${id}`;

export const NOTFOUND = '/notfound';