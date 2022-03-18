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
        description: existProduct.description,
        manufacturingDate: '2022-09-21',
        expiryDate: '2022-10-23',
        price: existProduct.price,
        type: existProduct.type,
        // imagePath: existProduct.imagePath,
        // imageFile: existProduct.imageFile
      });
    }
  }, [existProduct]);

  return (
    <div className='ml-5'>
      <div className='mt-3 primaryColor text-title intro-x'>
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
