import React, { useEffect, useState } from 'react'
import { Formik, Form } from 'formik'
import * as Yup from 'yup'
import { Link, useHistory } from 'react-router-dom'
import { NotificationManager } from 'react-notifications'
import 'bootstrap/dist/css/bootstrap.min.css';

import TextField from '../../share-components/FormInputs/TextField'
import SelectField from '../../share-components/FormInputs/SelectField'
import { PRODUCT } from '../../Constants/pages'
import { VegetableType } from '../../Constants/Product/ProductConstant'
import { ProductTypeOption } from '../../Constants/selectOptions'
import UploadImage from '../../share-components/FormInputs/UploadImage' 
import DateField from '../../share-components/FormInputs/DateField'
import {
  CreateProductRequest,
  UpdateProductRequest,
} from './services/request';



const initialFormValues = {
  productName: '',
  description: '',
  price: '',
  manufacturingDate: '',
  expiryDate: '',
  cateId: VegetableType,
  imageCreateRequest:{
    image1: '',
    image2: 'image2',
    image3: 'image3',
    image4: 'image4',
    image5: 'image5',
  },
}


const validationSchema = Yup.object().shape({
  productName: Yup.string().required('Required'),
  description: Yup.string().required('Required'),
  price: Yup.string().required('Required'),
  manufacturingDate: Yup.string().required('Required'),
  expiryDate: Yup.string().required('Required'),
  cateId: Yup.string().required('Required'),
})

const ProductFormContainer = ({
  initialProductForm = {
    ...initialFormValues,
  },
}) => {
  const [loading, setLoading] = useState(false);

  const isUpdate = initialProductForm.productId ? true : false;

  const history = useHistory();

  const handleResult = (result, message) => {
    if (result) {
      alert(`${isUpdate ? 'Update' : 'Create'} Successful Product ${message}`)

      setTimeout(() => {
        history.push(PRODUCT)
      }, 1000);
    } else {
      NotificationManager.error(message, 'Create failed', 2000);
    }
  }

  const handleFormatDate = (form) => {
    form.manufacturingDate = form.manufacturingDate.toISOString().split('T')[0];
    form.expiryDate = form.expiryDate.toISOString().split('T')[0];
    return form;
  }

  const updateProductAsync = async (form) => {
    let data = await UpdateProductRequest(handleFormatDate(form.formValues));
    if (data) {
      handleResult(true, '');
    }
  }

  const createProductAsync = async (form) => {
    let data = await CreateProductRequest(handleFormatDate(form.formValues));
    if (data) {
      handleResult(true, '');
    }
  }

  return (
    <Formik
      initialValues={initialProductForm}
      enableReinitialize
      validationSchema={validationSchema}
      onSubmit={(values) => {
        setLoading(true);

        setTimeout(() => {
          if (isUpdate) {
            updateProductAsync({ formValues: values });
          } else {
            createProductAsync({ formValues: values });
          }
          setLoading(false);
        }, 1000);
      }}
    >
      {(actions) => (
        <Form className="m-5 intro-y col-lg-6 col-12">
          <TextField
            name="productName"
            label="Name"
            placeholder="input product name"
            isrequired
            disabled={isUpdate ? true : false}
          />
          <TextField
            name="description"
            label="Description"
            placeholder="input product description"
            isrequired
          />
          <TextField
            name="price"
            label="Price"
            placeholder="input product price"
            isrequired
          />
          <DateField
            name="manufacturingDate"
            label="Manufacturing Date"
            isrequired
            update = {isUpdate ? true : false}
            disabled={isUpdate ? true : false}
          />
          <DateField
           name="expiryDate"
           label="Expire Date"
           isrequired
           update = {isUpdate ? true : false}
           disabled={isUpdate ? true : false}
           />
          <SelectField
            name="cateId"
            label="Type"
            isrequired
            options={ProductTypeOption}
          />
          <UploadImage
            name="imageCreateRequest.image1"
            update = {isUpdate ? true : false}
            label="Image"
          />
          <div className="d-flex">
            <div className="ml-auto">
              <button className="btn btn-danger m-3"
                type="submit" disabled={loading}
              >
                Save
              </button>

              <Link to={PRODUCT} className="btn btn-outline-secondary ml-2">
                Cancel
              </Link>
            </div>
          </div>
        </Form>
      )}
    </Formik>
  )
}

export default ProductFormContainer;
