import React, { useState } from "react";
import { useSelector,useDispatch } from 'react-redux';
import { useEffect } from "react";
import { render } from "@testing-library/react";
import { useNavigate, Navigate } from "react-router-dom";
    

function Profile()
{
    const dispatch = useDispatch()
    const user = useSelector((state)=> state.Profile)
    const login = useSelector((state)=> state.Login)
    console.log(login)

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