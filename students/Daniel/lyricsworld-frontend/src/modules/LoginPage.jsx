import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { useNavigate } from "react-router-dom";
import { Login } from "../store/state/LoginSlice";
import { changeLogged } from "../store/state/ProfileSlice";
import LoginPagecss from "../cssformodules/LoginPage.css"
import {Link} from 'react-router-dom'

function RegisterForm() {
    const dispatch = useDispatch()
    /* const user = useSelector((state) => state.Login)
    const profile = useSelector((state)=> state.Profile) */
    const navigate = useNavigate()

    const [details, setDetails] = useState({
        username: "",
        password: "",
    })

    const handleChange = (e) => {
        const name = e.target.name
        const value = e.target.value
        setDetails((set)=> {return{...set, [name]: value}})
    }
    const handleSubmit = (e) => 
    {
        dispatch(Login(details))
        dispatch(changeLogged())
        navigate("/profile")
    }

return(

    <div id="LoginContainer">
    <h1>Login</h1>
        <form>
            <div id="usernameinput">
            <label htmlFor="username">Username</label>
            <input type="text" name="username" onChange={handleChange}/>
            </div>
            <div id="passwordinput">
            <label htmlFor="password">Password</label>
            <input type="text" name="password" onChange={handleChange}/>
            </div>
            <input type="button" value="Log in" onClick={handleSubmit}/>

        </form>
        <h6>Don't have an account? <Link id="linktoregister" to="/register">Sign in</Link></h6>
    </div>)
}

export default RegisterForm

