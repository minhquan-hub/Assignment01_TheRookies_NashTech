const Endpoints = {
    product: '/api/Product/allproduct',
    createProduct: 'api/Product',
    productByCategory: 'api/Product/category',
    productId: (productId) => `/api/Product/${productId}`,

    category: '/api/Category',
    categoryId: (categoryId) => `/api/Category/${categoryId}`,

    cloudianry: '/quantran2102/upload'
}

export default Endpoints;