import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { Register } from "../store/state/RegisterSlice";
import { useEffect } from "react";
import { render } from "@testing-library/react";
import { useNavigate } from "react-router-dom";
import {Link} from 'react-router-dom'
import RegisterPagecss from '../cssformodules/RegisterPage.module.css'

function RegisterForm() {
    const dispatch = useDispatch()
    const user = useSelector((state) => state.User)
    const navigate = useNavigate()
    const [details, setDetails] = useState({
        username: "",
        password: "",
        email: ""
    })

    const handleChange = (e) => {
        const name = e.target.name
        const value = e.target.value
        setDetails((set)=> {return{...set, [name]: value}})
    }
    const handleSubmit = (e) => 
    {
        console.log(details)
        dispatch(Register(details))
        navigate('/')
    }

return(

    <div id="RegisterContainer">
        <h1>Register</h1>
        <form>
            <div id="usernameinput">
            <label htmlFor="username">Username</label>
            <input type="text" name="username" onChange={handleChange}/>
            </div>
            <div id="passwordinput">
            <label htmlFor="password">Password</label>
            <input type="text" name="password" onChange={handleChange}/>
            </div>
            <div id="emailinput">
            <label htmlFor="email">E-mail</label>
            <input type="text" name="email" onChange={handleChange}/>
            </div>
            <input type="button" value="Register" onClick={handleSubmit}/>
        </form>
        <h6>Alredy have an account? <Link id="linktologin" to="/login">Log in</Link></h6>
     </div>)
}

export default RegisterForm

 