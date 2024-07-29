import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { useEffect } from "react";
import { render } from "@testing-library/react";
import { useNavigate } from "react-router-dom";
import { Login } from "../store/state/LoginSlice";
import { changeLogged } from "../store/state/ProfileSlice";

function RegisterForm() {
    const dispatch = useDispatch()
    const user = useSelector((state) => state.Login)
    const profile = useSelector((state)=> state.Profile)
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
        console.log(user)
        dispatch(changeLogged())
        console.log(profile)
        navigate("/albums")
    }

return(

    <>
        <form>
            <input type="text" name="username" onChange={handleChange}/>
            <input type="text" name="password" onChange={handleChange}/>
            <input type="button" value="Log in" onClick={handleSubmit}/>
        </form>
    </>)
}

export default RegisterForm

