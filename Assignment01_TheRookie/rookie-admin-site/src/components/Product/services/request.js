import { AxiosResponse } from "axios";
import qs from "qs";

import RequestService from "../../../services/request";
import Endpoints from "../../../Constants/endpoints";

export function createProductRequest(productFrom) {
    const formData = new FormData();

    Object.keys(productFrom).forEach(key => {
        formData.append(key, productFrom[key]);
    });

    return RequestService.axios.post(Endpoints.product, formData);
}

export function getProductRequest(query) {
    console.log(query);
    var data = RequestService.axios.get(Endpoints.product);
    console.log(data);
    return RequestService.axios.get(Endpoints.product, {
        params: query,
        paramsSerializer: params => qs.stringify(params)
    });
}

export function UpdateProductRequest(productForm) {
    const formData = new FormData();

    Object.keys(productForm).forEach(key => {
        formData.append(key, productForm[key]);
    });

    return RequestService.axios.put(Endpoints.productId(productForm.id ?? -1), formData);
}

export function DisableProductRequest(productId) {
    return RequestService.axios.delete(Endpoints.productId(productId));
}