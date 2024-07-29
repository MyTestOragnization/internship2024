import React, {Component} from "react";
import logo from "../media/logo.png"
import profilePic from "../media/user.svg"
import css from "../cssformodules/HeaderModule.css"
import { Link } from "react-router-dom";
class Header extends Component {
    render() {
        return (
            <header>
            
            <a href="../App.js" className="HomeButton"><img src={logo} alt="logo of lyricsworld" className="Logo"></img></a>
            <button className="ProfileButton">
                <div className="coloredbutton">
                <object type="image/svg+xml" data={profilePic}></object>
                <Link className="coloredbuttontext" to={"/profile"}>Profile</Link>
                </div>  
            </button>
            
            </header>
        );
    }
}

export default Header