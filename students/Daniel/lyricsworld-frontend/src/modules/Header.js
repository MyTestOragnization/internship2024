import React, {Component} from "react";
import logo from "../media/logo.png"
import profilePic from "../media/user.svg"
import css from "../cssformodules/HeaderModule.css"
import { Link, useNavigate } from "react-router-dom";




function Header(){
    
        const navigate = useNavigate()

        return (
            <header>
            
            <Link to="/" className="HomeButton"><img src={logo} alt="logo of lyricsworld" className="Logo"></img></Link>
            <button className="ProfileButton">
                <div className="coloredbutton">
                <object type="image/svg+xml" data={profilePic}></object>
                <Link className="coloredbuttontext" to={"/profile"}>Profile</Link>
                </div>  
            </button>
            <style>
                
            </style>
            </header>

            
        );
    
}

export default Header