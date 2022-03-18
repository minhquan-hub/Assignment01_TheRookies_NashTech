const Endpoints = {
    product: '/api/Product/allproduct',
    productId: (productId) => `api/Product/${productId}`,

    category: '/api/Category',
    categoryId: (categoryId) => `api/Category/${categoryId}/`
}

export default Endpoints;