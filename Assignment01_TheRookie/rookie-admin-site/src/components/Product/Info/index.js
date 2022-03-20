import React from 'react'
import { Modal } from 'react-bootstrap'
import 'bootstrap/dist/css/bootstrap.min.css'

import {
  VegetableType,
  VegetableTypeLabel,
  FruitsType,
  FruitsTypeLabel,
  JuiceType,
  JuiceTypeLabel,
  DriesType,
  DriesTypeLabel,
} from '../../../Constants/Product/ProductConstant'

const Info = ({ product, handleClose }) => {
  const getProductTypeName = (cateId) => {
    var category = ''
    if (cateId === VegetableType) {
      category = VegetableTypeLabel
    } else if (cateId === FruitsType) {
      category = FruitsTypeLabel
    } else if (cateId === JuiceType) {
      category = JuiceTypeLabel
    } else {
      category = DriesTypeLabel
    }
    return category
  }

  return (
    <>
      <Modal show={true} onHide={handleClose} dialogClassName="modal-90w">
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">Detail Product Information</Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <div>
            <div className="d-flex  -intro-y">
              <div className="col-4">Id:</div>
              <div>{product.productId}</div>
            </div>

            <div className="d-flex -intro-y">
              <div className="col-4">Name:</div>
              <div>{product.productName}</div>
            </div>

            <div className="d-flex -intro-y">
              <div className="col-4">Description:</div>
              <div>{product.description}</div>
            </div>

            <div className="d-flex -intro-y">
              <div className="col-4">Type:</div>
              <div>{getProductTypeName(product.cateId)}</div>
            </div>

            <div className="row -intro-y">
              <div className="col-4">Image:</div>
              <div>
                <img
                  src={product.image.image1}
                  className="img-fluid object-center w-full rounded-md"
                />
              </div>
            </div>
          </div>
        </Modal.Body>
      </Modal>
    </>
  )
}

export default Info
