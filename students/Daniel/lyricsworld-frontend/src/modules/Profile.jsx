import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { Register } from "../store/state/RegisterSlice";
import { useEffect } from "react";
import { render } from "@testing-library/react";
import { useNavigate, Navigate } from "react-router-dom";
    

function Profile()
{
    const dispatch = useDispatch()
    const user = useSelector((state)=> state.Profile)
    console.log(user)

    if(user.isLogged == false)
    {
        return(<Navigate to="/login" replace />)
    }







    return(
        <div>
            test
        </div>
    )
}

export default Profile