import React, { useEffect, useState } from 'react'
import { Redirect, useParams, useLocation } from 'react-router';

import ProductForm from '../ProductForm';

const UpdateProductContainer = () => {
  const [product, setProduct] = useState(undefined);
  const {state} = useLocation();
  const { existProduct } = state; // Read values passed on state
  
  useEffect(() => {
    if (existProduct) {
      setProduct({
        productId: existProduct.productId,
        productName: existProduct.productName,
        type: existProduct.type,
        // imagePath: existProduct.imagePath,
        // imageFile: existProduct.imageFile
      });
    }
  }, [existProduct]);

  return (
    <div className='ml-5'>
      <div className='primaryColor text-title intro-x'>
        Update Product {existProduct?.productName}
      </div>

      <div className='row'>
        {
          product && (<ProductForm
            initialProductForm={product}
  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateProductContainer;
