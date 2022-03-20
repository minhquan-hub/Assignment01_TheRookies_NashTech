import React, { useEffect, useState } from 'react'
import { FunnelFill } from 'react-bootstrap-icons'
import { Button } from 'react-bootstrap'
import 'bootstrap/dist/css/bootstrap.min.css'
import Select from 'react-select'
import { Link } from 'react-router-dom'

import { FilterProductTypeOptions } from '../../../Constants/selectOptions'
import ProductTable from './ProductTable'
import { GetProductRequest } from '../services/request'
import { GetProductByCategoryRequest } from '../services/request'
import './List.css'
import {
  ACCSENDING,
  DECSENDING,
  DEFAULT_PRODUCT_SORT_COLUMN_NAME,
  DEFAULT_PAGE_LIMIT,
} from '../../../Constants/paging'

const ListProduct = () => {
  const [query, setQuery] = useState({
    page: 1,
    limit: DEFAULT_PAGE_LIMIT,
    sortOrder: DECSENDING,
    sortColumn: DEFAULT_PRODUCT_SORT_COLUMN_NAME,
  })

  const [search, setSearch] = useState('')
  const [products, setProducts] = useState('')
  const [mark, setMark] = useState(false)

  const [selectedType, setSelectedType] = useState([
    FilterProductTypeOptions[0],
  ])

  const handleType = (selected) => {
    console.log(selected.label)
    var categoryName = selected.label
    if (categoryName === 'All') {
      setQuery({
        ...query,
        search: '',
      })
      setSelectedType(FilterProductTypeOptions[0])
    } else {
      setQuery({
        ...query,
        search: categoryName,
      })
      setMark(true)
      if (categoryName === 'Vegetables') {
        setSelectedType(FilterProductTypeOptions[1])
      } else if (categoryName === 'Fruits') {
        setSelectedType(FilterProductTypeOptions[2])
      } else if (categoryName === 'Juice') {
        setSelectedType(FilterProductTypeOptions[3])
      } else {
        setSelectedType(FilterProductTypeOptions[4])
      }
    }
  }

  const handleChangeSearch = (e) => {
    e.preventDefault()

    const search = e.target.value
    setSearch(search)
  }

  const handlePage = (page) => {
    setQuery({
      ...query,
      page,
    })
  }

  const handleSearch = () => {
    setQuery({
      ...query,
      search,
    })
    setMark(false)
  }

  const handleSort = (sortColumn) => {
    const sortOrder = query.sortOrder === ACCSENDING ? DECSENDING : ACCSENDING

    setQuery({
      ...query,
      sortColumn,
      sortOrder,
    })
  }

  const fetchDataCallbackAsync = async () => {
    let result = await GetProductRequest(query)
    setProducts(result.data)
  }

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await GetProductRequest(query)
      setProducts(result.data)
    }

    async function fetchDataProductByCategoryAsync() {
      let result = await GetProductByCategoryRequest(query)
      setProducts(result.data)
    }

    if (mark) {
      fetchDataProductByCategoryAsync()
      setSearch('')
    } else {
      fetchDataAsync()
    }
    setMark(false)
  }, [query])

  return (
    <>
      <div className="text-success text-title fs-2 intro-x">Product List</div>

      <div>
        <div className="d-flex intro-x">
          <div className="d-flex align-items-center w-md mx-auto">
            <div className="m-3 size-select">
              <Select
                options={FilterProductTypeOptions}
                onChange={handleType}
                value={selectedType}
              />
            </div>

            <div>
              <div className="input-group">
                <input
                  type="text"
                  onChange={handleChangeSearch}
                  value={search}
                  className="form-control mr-2"
                  placeholder="Find Product"
                  aria-describedby="button-addon2"
                />
                <Button
                  onClick={handleSearch}
                  variant="primary"
                  type="button"
                  id="button-addon2"
                >
                  Find
                </Button>
              </div>
            </div>

            <button className="btn btn-danger m-3">
              <Link
                className="text-decoration-none text-dark"
                type="button"
                to="/product/create"
              >
                Create New Product
              </Link>
            </button>
          </div>
        </div>

        <ProductTable
          products={products}
          handlePage={handlePage}
          handleSort={handleSort}
          sortState={{
            columnValue: query.sortColumn,
            orderBy: query.sortOrder,
          }}
          fetchData={fetchDataCallbackAsync}
        />
      </div>
    </>
  )
}

export default ListProduct
