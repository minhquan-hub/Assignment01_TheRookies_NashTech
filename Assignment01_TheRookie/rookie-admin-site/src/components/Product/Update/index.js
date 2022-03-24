import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router';

import ProductForm from '../ProductForm';

const UpdateProductContainer = () => {
  const [product, setProduct] = useState(undefined);
  const {state} = useLocation();
  const { existProduct } = state; 
  
  useEffect(() => {
    if (existProduct) {
      setProduct({
        productId: existProduct.productId,
        productName: existProduct.productName,
        description: existProduct.description,
        manufacturingDate: existProduct.manufacturingDate,
        expiryDate: existProduct.expiryDate,
        price: existProduct.price,
        type: existProduct.type,
      });
    }
  }, [existProduct]);

  return (
    <div className='ml-5'>
      <div className='text-success text-title fs-2 intro-x'>
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
