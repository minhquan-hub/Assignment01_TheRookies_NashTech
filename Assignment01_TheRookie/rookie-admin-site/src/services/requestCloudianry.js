import axios from 'axios';
import { UrlCloudinary } from '../Constants/oidc-config';

const config = {
    baseURL : UrlCloudinary
}

class RequestCloudinary {
    axios;

    constructor() {
        this.axios = axios.create(config);
    }
}

export default new RequestCloudinary();
