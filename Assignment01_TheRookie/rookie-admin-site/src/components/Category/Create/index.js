import React, { useState } from 'react';

import CategoryForm from '../CategoryForm';

const CreteCategoryContainer = () => {
    return (
        <div className="ml-5">
            <div className="primarycolor text-title intro-x">
                Create New Category 
            </div>

            <div className="row">
                <CategoryForm/>
            </div>
        </div>
    )
}

export default CreteCategoryContainer;

