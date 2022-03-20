import { AxiosResponse } from 'axios';
import qs from 'qs';

import RequestService from '../../../services/request';
import Endpoints from '../../../Constants/endpoints';

export function CreateCategoryRequest(categoryFrom) {
    const formData = new FormData();

    Object.keys(categoryFrom).forEach(key => {
        formData.append(key, categoryFrom[key]);
    });

    return RequestService.axios.post(Endpoints.category, formData);
}

export function GetCategoryRequest() {
    return RequestService.axios.get(Endpoints.category);
}

export function UpdateCategoryRequest(categoryForm) {
    const formData = new FormData();

    Object.keys(categoryForm).forEach(key => {
        formData.append(key, categoryForm[key]);
    });

    return RequestService.axios.put(Endpoints.categoryId(categoryForm.categoryId), formData);
}

export function DisableCategoryRequest(categoryId) {
    return RequestService.axios.delete(Endpoints.categoryId(categoryId));
}