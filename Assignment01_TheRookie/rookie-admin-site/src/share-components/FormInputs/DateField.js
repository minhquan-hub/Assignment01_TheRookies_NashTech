import React, { InputHTMLAttributes, useEffect, useState } from 'react'
import { useField } from 'formik'
import { CalendarDateFill } from 'react-bootstrap-icons'
import DatePicker from 'react-datepicker'
import 'react-datepicker/dist/react-datepicker.css'

const DateField = (props) => {
  const [{ value }, { error, touched }, { setValue }] = useField(props)
  const {
    label,
    isrequired,
    notvalidate,
    maxDate,
    minDate,
    filterDate,
    update,
  } = props
  const [value1, setValue1] = useState('')
  const [mark, setMark] = useState(false)

  const validateClass = () => {
    if (touched && error) return 'is-invalid'
    if (notvalidate) return ''
    if (touched) return 'is-valid'

    return ''
  }

  const handleChangeAssignedDate = (assignDate) => {
    setMark(true)
    setValue(assignDate)
  }

  useEffect(() => {
    if (update || mark) {
      setValue1(new Date(value))
    }
  }, [value])

  return (
    <>
      <div className="mb-3 row">
        <label className="col-4 col-form-label d-flex">
          {label}
          {isrequired && <div className="invalid ml-1">(*)</div>}
        </label>
        <div className="col">
          <div className="d-flex align-items-center w-100">
            <DatePicker
              placeholderText={label}
              className="w-100 text-center is-invalid"
              dateFormat="yyyy-MM-dd"
              selected={value1}
              onChange={(date) => handleChangeAssignedDate(date)}
              showDisabledMonthNavigation
              maxDate={maxDate}
              minDate={minDate}
              filterDate={filterDate}
            />
          </div>
        </div>
      </div>
    </>
  )
}
export default DateField
