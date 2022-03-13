import React, { useEffect, useState } from 'react'
import { FunnelFill } from 'react-bootstrap-icons'
import { Button } from 'react-bootstrap'
import { Search } from 'react-feather'
//import ReactMultiSelectCheckboxes from 'react-multiselect-checkboxes';
import { Link } from 'react-router-dom'
import { FilterProductTypeOptions } from '../../../Constants/selectOptions'
import ProductTable from './ProductTable'
import { getProductRequest } from '../services/request'
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

  const [selectedType, setSelectedType] = useState([
    { id: 1, label: 'Vegetables', value: 0 },
  ])

  const handleType = (selected) => {
    if (selected.length === 0) {
      setQuery({
        ...query,
        types: [],
      })

      setSelectedType([FilterProductTypeOptions[0]])
      return
    }

    const selectedAll = selected.find((item) => item.id === 1)

    setSelectedType((prevSelected) => {
      if (!prevSelected.some((item) => item.id === 1) && selectedAll) {
        setQuery({
          ...query,
          types: [],
        })

        return [selectedAll]
      }

      const newSelected = selected.filter((item) => item.id !== 1)
      const types = newSelected.map((item) => item.value)

      setQuery({
        ...query,
        types,
      })

      return newSelected
    })
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
    let data = await getProductRequest(query)
    console.log(data)
    setProducts(data)
  }

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getProductRequest(query)
      setProducts(result.data)
    }

    fetchDataAsync()
  }, [])

  return (
    <>
      <div className="text-success text-title intro-x">Product List</div>

      <div>
        <div className="d-flex mb-5 intro-x">
          <div className="d-flex align-items-center w-md mr-5">
            {/* <ReactMultiSelectCheckboxes
              options={FilterProductTypeOption}
              hideSearch={true}
              placeholderButtonLabel="Type"
              //value={selectedType}
              onChange={handleType}
            /> */}
            <div>
              <div className="input-group">
                <input
                  type="text"
                  onChange={handleChangeSearch}
                  value={search}
                  class="form-control"
                  placeholder="Find Product"
                  aria-describedby="button-addon2"
                />
                <Button
                  onClick={handleSearch}
                  variant="primary"
                  type="button"
                  id="button-addon2"
                >
                  Button
                </Button>
              </div>
            </div>

            <button className="btn btn-success">
              <Link type="button" to="/product/create">
                Create new Product
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
