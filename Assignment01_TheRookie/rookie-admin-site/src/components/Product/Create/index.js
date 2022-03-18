import React, { useState } from "react";

import ProductForm from "../ProductForm";

const CreateProductContainer = () => {
    return (
        <div className="ml-5">
            <div className="primaryColor text-title intro-x">
                Create New Product
            </div>

            <div className="row">
                <ProductForm/>
            </div>
        </div>
    );
};

export default CreateProductContainer;