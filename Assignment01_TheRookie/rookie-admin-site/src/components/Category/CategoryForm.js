import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useHistory } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';
import 'bootstrap/dist/css/bootstrap.min.css';

import TextField from '../../share-components/FormInputs/TextField';
import { CATEGORY } from '../../Constants/pages';
import {
  CreateCategoryRequest,
  UpdateCategoryRequest,
} from './Services/request';

const initialFormValues = {
  categoryName: '',
  description: '',
}

const validationSchema = Yup.object().shape({
  categoryName: Yup.string().required('Required'),
  description: Yup.string().required('Required'),
})

const CategoryFormContainer = ({
  initialCategoryForm = {
    ...initialFormValues,
  },
}) => {
  const [loading, setLoading] = useState(false)

  const isUpdate = initialCategoryForm.categoryId ? true : false

  const history = useHistory()

  const handleResult = (result, message) => {
    if (result) {
      alert(`${isUpdate ? 'Update' : 'Create'} Successful Category ${message}`)
        
      setTimeout(() => {
        history.push(CATEGORY)
      }, 1000)
    } else {
      NotificationManager.error(message, 'Create failed', 2000)
    }
  }

  const updateCategoryAsync = async (form) => {
    let data = await UpdateCategoryRequest(form.formValues)
    if (data) {
      handleResult(true, '')
    }
  }

  const createCategoryAsync = async (form) => {
    let data = await CreateCategoryRequest(form.formValues)
    if (data) {
      handleResult(true, '')
    }
  }

  return (
    <Formik
      initialValues={initialCategoryForm}
      enableReinitialize
      validationSchema={validationSchema}
      onSubmit={(values) => {
        setLoading(true)

        setTimeout(() => {
          if (isUpdate) {
            updateCategoryAsync({ formValues: values })
          } else {
            createCategoryAsync({ formValues: values })
          }
          setLoading(false)
        }, 1000)
      }}
    >
      {(actions) => (
        <Form className="m-5 intro-y col-lg-6 col-12">
          <TextField
            name="categoryName"
            label="Category Name"
            placeholder="input category name"
            isrequired
            disabled={isUpdate ? true : false}
          />
          <TextField
            name="description"
            label="Description"
            placeholder="input description"
            isrequired
          />
          <div className="d-flex">
            <div className="ml-auto">
              <button
                className="btn btn-danger"
                type="submit"
                disabled={loading}
              >
                Save
              </button>

              <Link to={CATEGORY} className="btn btn-outline-secondary ml-2">
                Cancel
              </Link>
            </div>
          </div>
        </Form>
      )}
    </Formik>
  )
}

export default CategoryFormContainer
