import React, { useEffect, useState } from 'react'
import { Formik, Form } from 'formik'
import * as Yup from 'yup'
import { Link, useHistory } from 'react-router-dom'
import { NotificationManager } from 'react-notifications'
import "bootstrap/dist/css/bootstrap.min.css";

import TextField from '../../share-components/FormInputs/TextField'
import SelectField from '../../share-components/FormInputs/SelectField'
import { PRODUCT } from '../../Constants/pages'
import { VegetableType } from '../../Constants/Product/ProductConstant'
import { ProductTypeOption } from '../../Constants/selectOptions'
import FileUpload from '../../share-components/FormInputs/FileUpload'
import {
  CreateProductRequest,
  UpdateProductRequest,
} from './services/request'

const initialFormValues = {
  productName: '',
  type: VegetableType,
  imageFile: undefined,
}

const validationSchema = Yup.object().shape({
  name: Yup.string().required('Required'),
  type: Yup.string().required('Required'),
})

const ProductFormContainer = ({
  initialProductForm = {
    ...initialFormValues,
  },
}) => {
  const [loading, setLoading] = useState(false)

  const isUpdate = initialProductForm.productId ? true : false

  const history = useHistory()

  const handleResult = (result, message) => {
    if (result) {
      NotificationManager.success(
        `${isUpdate ? 'Update' : 'Created'} Successful Product ${message}`,
        `${isUpdate ? 'Update' : 'Create'} Successful`,
        2000,
      )

      setTimeout(() => {
        history.push(PRODUCT)
      }, 1000)
    } else {
      NotificationManager.error(message, 'Create failed', 2000)
    }
  }

  const updateProductAsync = async (form) => {
    console.log('update product async')
    let data = await UpdateProductRequest(form.formValues)
    if (data) {
      handleResult(true, data.name)
    }
  }

  const createProductAsync = async (form) => {
    console.log('create product async')
    let data = await CreateProductRequest(form.formValues)
    if (data) {
      handleResult(true, data.name)
    }
  }

  return (
    <Formik
      initialValues={initialProductForm}
      enableReinitialize
      validationSchema={validationSchema}
      onSubmit={(values) => {
        setLoading(true)

        setTimeout(() => {
          if (isUpdate) {
            updateProductAsync({ formValues: values })
          } else {
            createProductAsync({ formValues: values })
          }
          setLoading(false)
        }, 1000)
      }}
    >
      {(actions) => (
        <Form className="intro-y col-lg-6 col-12">
          <TextField
            name="productName"
            label="Name"
            placeholder="input product name"
            isrequired
            disabled={isUpdate ? true : false}
          />
          <SelectField
            name="type"
            label="Type"
            options={ProductTypeOption}
            isrequired
          />
          <FileUpload
            name="imageFile"
            label="Image"
            image={actions.values.imagePath}
          />

          <div className="d-flex">
            <div className="ml-auto">
              <button
                className="btn btn-danger"
                type="submit"
                disabled={loading}
              >
                Save{' '}
                {loading && (
                  <img src="/oval.svg" className="w-4 h-4 ml-2 inline-block" />
                )}
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
