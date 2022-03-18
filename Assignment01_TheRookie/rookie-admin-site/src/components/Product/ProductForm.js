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
import FileUpload from '../../share-components/FormInputs/FileUpload'
import DateField from '../../share-components/FormInputs/DateField'
import {
  CreateProductRequest,
  UpdateProductRequest,
} from './Services/request';

const initialFormValues = {
  productName: '',
  description: '',
  price: '',
  manufacturingDate: '',
  expiryDate: '',
  cateId: VegetableType,
  imageFile: undefined,
}

const validationSchema = Yup.object().shape({
  productName: Yup.string().required('Required'),
  description: Yup.string().required('Required'),
  price: Yup.string().required('Required'),
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
      NotificationManager.success(
        `${isUpdate ? 'Update' : 'Created'} Successful Product ${message}`,
        `${isUpdate ? 'Update' : 'Create'} Successful`,
        2000,
      );

      setTimeout(() => {
        history.push(PRODUCT)
      }, 1000);
    } else {
      NotificationManager.error(message, 'Create failed', 2000);
    }
  }

  const updateProductAsync = async (form) => {
    console.log('update product async');
    let data = await UpdateProductRequest(form.formValues);
    if (data) {
      handleResult(true, data.name);
    }
  }

  const createProductAsync = async (form) => {
    console.log('create product async');
    let data = await CreateProductRequest(form.formValues);
    if (data) {
      handleResult(true, data.name);
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
          {/* <DateField
            name="manufacturingDate"
            label="Manufacturing Date"
            isrequired
          />
          <DateField
           name="expiryDate"
           label="Expire Date"
           isrequired
           /> */}
          <SelectField
            name="cateId"
            label="Type"
            isrequired
            options={ProductTypeOption}
          />
          <FileUpload
            name="imageFile"
            label="Image"
            image={actions.values.imagePath}
          />

          <div className="d-flex">
            <div className="ml-auto">
              <button className="btn btn-danger"
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
