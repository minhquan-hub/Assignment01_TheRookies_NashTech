import React, { useEffect, useState } from 'react';
import { useLocation } from 'react-router';

import CategoryForm from '../CategoryForm';

const UpdateCategoryContainer = () => {
    const [categories, setCategories] = useState(undefined);
    const {state} = useLocation();
    const { existCategory } = state;

    useEffect(() => {
        if(existCategory) {
            setCategories({
                categoryId: existCategory.categoryId,
                categoryName: existCategory.categoryName,
                description: existCategory.description
            });
        }
    }, [existCategory]);

    return (
        <div className="ml-5">
            <div className="mt-3 primaryColor text-title intro-x">
                Update Category {existCategory?.categoryName}
            </div>

            <div className="row">
                {
                    categories && (<CategoryForm
                        initialCategoryForm = {categories}
                    />)
                }
            </div>
        </div>
    )
}

export default UpdateCategoryContainer;