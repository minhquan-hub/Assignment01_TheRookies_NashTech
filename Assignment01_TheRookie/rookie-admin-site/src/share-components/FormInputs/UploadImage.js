import React, { useState } from 'react';
import Axios from 'axios';
import "bootstrap/dist/css/bootstrap.min.css";
import { useField } from 'formik';

import RequestCloudinary from "../../services/requestCloudianry" 
import Endpoints from "../../Constants/endpoints"

const UploadImage = (props) => {
    const [value, , { setValue }] = useField(props);

    const handleHidden = () => {
        if(props.update){
            return "d-none"
        }
    }

    const handleUpload = (files) => {
        console.log(files[0]);
        const formData = new FormData();
        formData.append("file", files[0]);
        formData.append("upload_preset", "thfhhall");

        RequestCloudinary.axios.post(Endpoints.cloudianry, formData)
        .then((response) => {
            console.log(response);
            setValue(response.data.secure_url);
        })
    }

    return (
        <div className={`mb-3 row ${handleHidden()}`}>
            <label className="col-4 col-form-label d-flex">{props.label}</label>
            <div className="col-4 align-self-center">
                <input type="file" onChange={(event) => handleUpload(event.target.files)} ></input>
            </div>
        </div>
    )
}

export default UploadImage;