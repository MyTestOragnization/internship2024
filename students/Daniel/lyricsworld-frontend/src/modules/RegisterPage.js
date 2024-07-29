import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { Register } from "../store/state/RegisterSlice";
import { useEffect } from "react";
import { render } from "@testing-library/react";
import { useNavigate } from "react-router-dom";
    


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

    <>
        <form>
            <input type="text" name="username" onChange={handleChange}/>
            <input type="text" name="password" onChange={handleChange}/>
            <input type="text" name="email" onChange={handleChange}/>
            <input type="button" value="Register" onClick={handleSubmit}/>
        </form>
    </>)
}

export default RegisterForm

