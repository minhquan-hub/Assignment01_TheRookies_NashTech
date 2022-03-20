import React, { useState } from "react";

import ProductForm from "../ProductForm";

const CreateProductContainer = () => {
    return (
        <div className="ml-5">
            <div className="text-success text-title fs-2 intro-x">
                Create New Product
            </div>

            <div className="row">
                <ProductForm/>
            </div>
        </div>
    );
};

export default CreateProductContainer;