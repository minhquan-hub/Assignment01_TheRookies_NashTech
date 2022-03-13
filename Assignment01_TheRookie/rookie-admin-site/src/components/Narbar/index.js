import React from 'react'
import { Link } from 'react-router-dom'
import { UserContext } from '../../index'
import "./Navbar.css"

const Navbar = (props) => {
  return (
    <UserContext.Consumer>
      {(value) => (
        <nav id="navbar">
          <ul>
            <Link className="link" to="">
              <li>Home</li>
            </Link>
            <Link className="link" to="/contact">
              <li>Contact</li>
            </Link>
            <Link className="link" to="/about">
              <li>About</li>
            </Link>
            <Link className="link" to="/product">
              <li>Product</li>
            </Link>
          </ul>

          <input type="text" onChange={(e) => this.props.onSearchKey(e)}></input>

          <div className="nav-details">
            <p className="nav-username">{value.username}</p>
          </div>
        </nav>
      )}
    </UserContext.Consumer>
  )
}

export default Navbar
