import { AxiosResponse } from 'axios';
import qs from 'qs';

import RequestService from '../../../services/request';
import Endpoints from '../../../Constants/endpoints';

export function CreateProductRequest(productForm) {
    const formData = new FormData();
    for(let dataKey in productForm) {
        if(dataKey === "imageCreateRequest"){
            for(let imageKey in productForm[dataKey]){
                formData.append(`imageCreateRequest[${imageKey}]`, productForm[dataKey][imageKey]);
            }
        }else{
            formData.append(dataKey, productForm[dataKey]);
        }
    }
    return RequestService.axios.post(Endpoints.createProduct, formData);
}

export function GetProductRequest(query) {
    return RequestService.axios.get(Endpoints.product, {
        params: query,
        paramsSerializer: params => qs.stringify(params)
    });
}

export function GetProductByCategoryRequest(query) {
    return RequestService.axios.get(Endpoints.productByCategory, {
        params: query,
        paramsSerializer: params => qs.stringify(params)
    });
}

export function UpdateProductRequest(productForm) {
    const formData = new FormData();

    for(let dataKey in productForm) {
        if(dataKey === "imageCreateRequest"){
            for(let imageKey in productForm[dataKey]){
                formData.append(`imageCreateRequest[${imageKey}]`, productForm[dataKey][imageKey]);
            }
        }else{
            formData.append(dataKey, productForm[dataKey]);
        }
    }
    return RequestService.axios.put(Endpoints.productId(productForm.productId ?? -1), formData);
}

export function DisableProductRequest(productId) {
    return RequestService.axios.delete(Endpoints.productId(productId));
}