import React, { InputHTMLAttributes } from 'react';
import { useField } from 'formik';
import { CalendarDateFill } from "react-bootstrap-icons";
import DatePicker from 'react-datepicker';
import "react-datepicker/dist/react-datepicker.css";

const DateField = (props) => {
    const [{ value }, { error, touched }, { setValue }] = useField(props);
    const {
        label, isrequired, notvalidate, maxDate, minDate, filterDate,
    } = props;

    const validateClass = () => {
        if (touched && error) return 'is-invalid';
        if (notvalidate) return '';
        if (touched) return 'is-valid';

        return '';
    };

    const handleChangeAssignedDate = (assignDate) => {
        setValue(assignDate);
    };

    return (
        <>
            <div className="mb-3 row">
                <label className="col-4 col-form-label d-flex">
                    {label}
                    {isrequired && (
                        <div className="invalid ml-1">(*)</div>
                    )}
                </label>
                <div className="col">
                    <div className="d-flex align-items-center w-100">
                        <DatePicker
                            placeholderText={label}
                            className='border w-100 text-center is-invalid'
                            dateFormat='yyyy-MM-dd'
                            selected={value}
                            onChange={date => handleChangeAssignedDate(date)}
                            isClearable
                            showDisabledMonthNavigation
                            maxDate={maxDate}
                            minDate={minDate}
                            filterDate={filterDate}
                        />

                        {/* <div className="border p-2">
                            <CalendarDateFill />
                        </div> */}
                    </div>
                </div>
            </div>
        </>
    );
};
export default DateField;
