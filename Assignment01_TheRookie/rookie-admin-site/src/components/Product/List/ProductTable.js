import React, { useState } from 'react'
import { PencilFill, XCircle } from 'react-bootstrap-icons'
import { useHistory } from 'react-router'
import 'bootstrap/dist/css/bootstrap.min.css'

import Table, { SortType } from '../../../share-components/Table'
import ButtonIcon from '../../../share-components/ButtonIcon'
import { DisableProductRequest } from '../services/request'
import Info from '../Info'
import { EDIT_PRODUCT_ID } from '../../../Constants/pages'
import ConfirmModal from '../../../share-components/ConfirmModal'
import {
  VegetableType,
  VegetableTypeLabel,
  FruitsType,
  FruitsTypeLabel,
  JuiceType,
  JuiceTypeLabel,
  DriesTypeLabel,
} from '../../../Constants/Product/ProductConstant'

const columns = [
  { columnName: 'ID', columnValue: 'ProductID' },
  { columnName: 'NAME', columnValue: 'ProductName' },
  { columnName: 'PRICE', columnValue: 'ProductPrice' },
  { columnName: 'TYPE', columnValue: 'Type' },
]

const ProductTable = ({
  products,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false)
  const [productDetail, setProductDetail] = useState(null)
  const [disableState, setDisable] = useState({
    isOpen: false,
    productId: '',
    title: '',
    message: '',
    isDisable: true,
  })

  const handleShowInfo = (productId) => {
    const product = products.items.find((item) => item.productId === productId)

    if (product) {
      setProductDetail(product)
      setShowDetail(true)
    }
  }

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

  const handleShowDisable = async (productId) => {
    setDisable({
      productId,
      isOpen: true,
      title: 'Are you sure',
      message: 'Do you want to disable this Product ?',
      isDisable: true,
    })
  }

  const handleCloseDisable = () => {
    setDisable({
      isOpen: false,
      productId: '',
      title: '',
      message: '',
      isDisable: true,
    })
  }

  const handleResult = async (result, message) => {
    if (result) {
      handleCloseDisable()
      await fetchData()
      alert('Remove Product Successful')
    } else {
      setDisable({
        ...disableState,
        title: 'Can not disable Product',
        message,
        isDisable: result,
      })
    }
  }

  const handleConfirmDisable = async () => {
    let isSuccess = await DisableProductRequest(disableState.productId)
    if (isSuccess) {
      await handleResult(true, '')
    }
  }

  const handleCloseDetail = () => {
    setShowDetail(false)
  }

  const history = useHistory()
  const handleEdit = (productId) => {
    const existProduct = products?.items.find(
      (item) => item.productId === productId,
    )
    history.push(EDIT_PRODUCT_ID(productId), {
      existProduct: existProduct,
    })
  }

  return (
    <>
      <Table
        columns={columns}
        handleSort={handleSort}
        sortState={sortState}
        page={{
          currentPage: products?.currentPage,
          totalPage: products?.totalPages,
          handleChange: handlePage,
        }}
      >
        {products &&
          products?.items?.map((data, index) => (
            <tr
              key={index}
              className=""
              onClick={() => handleShowInfo(data.productId)}
            >
              <td>{data.productId}</td>
              <td>{data.productName}</td>
              <td>${data.price}</td>
              <td>{getProductTypeName(data.cateId)}</td>

              <td className="d-flex">
                <ButtonIcon onClick={() => handleEdit(data.productId)}>
                  <PencilFill className="text-black" />
                </ButtonIcon>
                <ButtonIcon onClick={() => handleShowDisable(data.productId)}>
                  <XCircle className="text-danger mx-2" />
                </ButtonIcon>
              </td>
            </tr>
          ))}
      </Table>
      {productDetail && showDetail && (
        <Info product={productDetail} handleClose={handleCloseDetail} />
      )}
      <ConfirmModal
        title={disableState.title}
        isShow={disableState.isOpen}
        onHide={handleCloseDisable}
      >
        <div>
          <div className="text-center">{disableState.message}</div>
          {disableState.isDisable && (
            <div className="text-center">
              <button
                className="btn btn-danger m-3"
                onClick={handleConfirmDisable}
                type="button"
              >
                Disable
              </button>

              <button
                className="btn btn-outline-primary"
                onClick={handleCloseDisable}
                type="button"
              >
                Cancel
              </button>
            </div>
          )}
        </div>
      </ConfirmModal>
    </>
  )
}

export default ProductTable
