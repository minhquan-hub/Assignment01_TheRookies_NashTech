import React from 'react';

import CategoryForm from '../CategoryForm';

const CreteCategoryContainer = () => {
    return (
        <div className="ml-5">
            <div className="text-success text-title fs-2 intro-x">
                Create New Category 
            </div>

            <div className="row">
                <CategoryForm/>
            </div>
        </div>
    )
}

export default CreteCategoryContainer;

