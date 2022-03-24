import React, { useEffect, useState } from 'react';
import { Pen, PencilFill, XCircle } from 'react-bootstrap-icons';
import { useHistory } from 'react-router';
import { Button } from 'react-bootstrap';
import "bootstrap/dist/css/bootstrap.css";
import { Link } from 'react-router-dom';

import ButtonIcon from '../../../share-components/ButtonIcon'
import { EDIT_CATEGORY_ID } from '../../../Constants/pages'
import { DisableCategoryRequest, GetCategoryRequest } from '../Services/request'
import ConfirmModal from '../../../share-components/ConfirmModal';

const columns = [
    { columnName: 'ID', columnValue: 'CategoryId'},
    { columnName: 'NAME', columnValue: 'CategoryName'},
    { columnName: 'DESCRIPTION', columnValue: 'CategoryDescription'}
]

const ListCategory = () => {
    const [categories, setCategories] = useState('');
    const [disableState, setDisable] = useState({
        isOpen: false,
        categoryId: '',
        title: '',
        message: '',
        isDisable: true,
    });


    const handleShowDisable =  (categoryId) => {
        setDisable({
            categoryId,
            isOpen: true,
            title: 'Are you sure',
            message: 'Do you want to disable this category ?',
            isDisable: true,
        });
    }

    const handleCloseDisable = () => {
        setDisable({
            isOpen: false,
            categoryId: '',
            title: '',
            message: '',
            isDisable: true,
        })
    }

    const handleResult = async (result, message) => {
        if (result) {
            handleCloseDisable();
            await fetchDataAsync();
            alert("Remove Category Successful");
        }else {
            setDisable({
                ...disableState,
                title: 'Can not disable Category',
                message,
                isDisable: result,
            })
        }
    }

    const handleConfirmDisable = async () => {
        let isSuccess = await DisableCategoryRequest(disableState.categoryId);
        if (isSuccess) {
            await handleResult(true, '');
        }
    }

    const history = useHistory();
    const handleEdit = (categoryId) => {
        const existCategory = categories?.find((item) => item.categoryId === categoryId);
        history.push(EDIT_CATEGORY_ID(categoryId), { 
            existCategory : existCategory
        });
    }

    async function fetchDataAsync() {
        let result = await GetCategoryRequest();
        setCategories(result.data);
    }

    useEffect(() =>{
        fetchDataAsync();
    },[])

    return (
        <>
            <div className="text-success text-title fs-2 intro-x">Category List</div>

            <div>
                <div>
                    <button className="btn btn-danger m-3">
                        <Link className="text-decoration-none text-dark" type="button" to="/category/create">
                            Create New Category
                        </Link>
                    </button>
                </div>

                <div className="table-container">
                    <table className="table">
                        <thead>
                            <tr>
                                {
                                    columns.map((col, i) => (
                                        <th key={i}>
                                            {col.columnName}
                                        </th>
                                    )) 
                                }
                            </tr>
                        </thead>
                        <tbody>
                            {categories && categories.map((data, index) => (
                                <tr className="" key={index}> 
                                    <td className="col" >{data.categoryId}</td>
                                    <td className="col" >{data.categoryName}</td>
                                    <td className="col-10" >{data.description}</td>
                                    <td className="d-flex">
                                        <ButtonIcon onClick={() => handleEdit(data.categoryId)} >
                                            <PencilFill className="text-black"/>
                                        </ButtonIcon>
                                        <ButtonIcon onClick={() => handleShowDisable(data.categoryId)}>
                                            <XCircle className="text-danger mx-2"/>
                                        </ButtonIcon>
                                    </td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                </div>
            </div>
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

export default ListCategory;