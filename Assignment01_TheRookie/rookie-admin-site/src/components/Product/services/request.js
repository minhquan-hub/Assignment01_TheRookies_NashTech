import { AxiosResponse } from "axios";
import qs from "qs";

import RequestService from "../../../services/request";
import Endpoints from "../../../Constants/endpoints";

export function CreateProductRequest(productFrom) {
    const formData = new FormData();

    Object.keys(productFrom).forEach(key => {
        formData.append(key, productFrom[key]);
    });

    return RequestService.axios.post(Endpoints.product, formData);
}

export function GetProductRequest(query) {
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

    return RequestService.axios.put(Endpoints.productId(productForm.productId ?? -1), formData);
}

export function DisableProductRequest(productId) {
    return RequestService.axios.delete(Endpoints.productId(productId));
}