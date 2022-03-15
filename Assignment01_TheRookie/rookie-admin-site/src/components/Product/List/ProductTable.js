import React, { useState } from "react";
import { PencilFill, XCircle } from "react-bootstrap-icons";
import { useHistory } from "react-router";
import ButtonIcon from "../../../share-components/ButtonIcon";
import { NotificationManager } from "react-notifications";

import Table, { SortType } from "../../../share-components/Table";
import {DisableProductRequest} from "../services/request"
import Info from '../Info';
import { EDIT_PRODUCT_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../share-components/ConfirmModal";
import {
  VegetableType,
  VegetableTypeLabel,
  FruitsType,
  FruitsTypeLabel,
  JuiceType,
  JuiceTypeLabel,
  DriesType,
  DriesTypeLabel,
} from "../../../Constants/Product/ProductConstant";

const columns = [
  { columnName: 'prodcutid', columnValue: 'ProductID' },
  { columnName: 'productname', columnValue: 'ProductName' },
  { columnName: 'productprice', columnValue: 'ProductPrice' },
  { columnName: 'type', columnValue: 'Type' },
];

const ProductTable = ({
  products,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [productDetail, setProductDetail] = useState(null);
  const [disableState, setDisable] = useState({
    isOpen: false,
    id: 0,
    title: '',
    message: '',
    isDisable: true,
  });

  const handleShowInfo = (id) => {
    const product = products.items.find((item) => item.productId === id);

    if (product) {
      setProductDetail(product)
      setShowDetail(true)
    }
  }

  const getProductTypeName = (id) => {
    return id == VegetableTypeLabel ? VegetableTypeLabel : FruitsTypeLabel
  }

  const handleShowDisable = async (id) => {
    setDisable({
      id,
      isOpen: true,
      title: 'Are you sure',
      message: 'Do you want to disable this Product ?',
      isDisable: true,
    });
  }

  const handleCloseDisable = () => {
    setDisable({
      isOpen: false,
      id: 0,
      title: '',
      message: '',
      isDisable: true,
    });
  }

  const handleResult = async (result, message) => {
    if (result) {
      handleCloseDisable()
      await fetchData()
      NotificationManager.success(
        'Remove Product Successful',
        'Remove Successful',
        2000,
      );
    } else {
      setDisable({
        ...disableState,
        title: 'Can not disable Product',
        message,
        isDisable: result,
      });
    }
  }

  const handleConfirmDisable = async () => {
      let isSuccess = await DisableProductRequest(disableState.id);
      if (isSuccess) {
        await handleResult(true, '');
      }
    };

  const handleCloseDetail = () => {
    setShowDetail(false)
  }

  const history = useHistory()
  const handleEdit = (id) => {
    const existProduct = products?.items.find((item) => item.productId === id);
    history.push(EDIT_PRODUCT_ID(id), {
      existProduct: existProduct,
    });
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
              <td>{getProductTypeName(data.type)}</td>

              <td className="d-flex">
                <ButtonIcon onClick={() => handleEdit(data.productId)}>
                  <PencilFill className="text-black" />
                </ButtonIcon>
                <ButtonIcon onClick={() => handleShowDisable(data.id)}>
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
            <div>
              <button
                className="btn btn-danger mr-3"
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
