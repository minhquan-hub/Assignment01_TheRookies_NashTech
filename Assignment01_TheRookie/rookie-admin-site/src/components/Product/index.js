import React, {lazy} from 'react';
import {Route, Switch} from 'react-router-dom';

import {CREATE_PRODUCT, PRODUCT, EDIT_PRODUCT} from '../../Constants/pages'

const ListProduct = lazy(() => import("./List"));

const Product = () => {
    return (
        <Switch>
            <Route exact path={PRODUCT}>
                <ListProduct/>
            </Route>
            <Route exact path={CREATE_PRODUCT}>

            </Route>
            <Route exact path={EDIT_PRODUCT}>
            </Route>
        </Switch>
    )
};

export default Product;