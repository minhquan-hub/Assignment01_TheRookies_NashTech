import React from "react";
import { Modal } from "react-bootstrap";

import {
    VegetableType,
    VegetableTypeLabel,
    FruitsType,
    FruitsTypeLabel,
    JuiceType,
    JuiceTypeLabel,
    DriesType,
    DriesTypeLabel
} from "../../../Constants/Product/ProductConstant";

const Info = ({ product, handleClose }) => {
    const getProductTypeName = (id) => {
        return id == VegetableType ? VegetableTypeLabel : FruitsTypeLabel;
    };


    return (
        <>
            <Modal 
                show={true}
                onHide={handleClose}
                dialogClassName="modal-90w"
            >
                <Modal.Header closeButton>
                    <Modal.Title id="login-modal">
                        Detail Product Information
                    </Modal.Title>
                </Modal.Header>

                <Modal.Body>
                    <div>
                        <div className="row -intro-y">
                            <div className="col-4">Id:</div>
                            <div>{product.id}</div>
                        </div>

                        <div className="row -intro-y">
                            <div className="col-4">Name:</div>
                            <div>{product.name}</div>
                        </div>

                        <div className="row -intro-y">
                            <div className="col-4">Type:</div>
                            <div>{getProductTypeName(product.type)}</div>
                        </div>

                        {/* <div className="row -intro-y">
                            <div className="col-4">Image</div>
                            <div>
                                <img src={} className="object-center w-full rounded-md"/>
                            </div>
                        </div> */}
                    </div>
                </Modal.Body>

            </Modal>
        </>
    );
}

export default Info;
