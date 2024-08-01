import { useParams } from "react-router-dom"
import React, { useEffect, useState } from "react";
import Header from "./Header";
import { useDispatch, useSelector } from "react-redux";
import {oneSong} from '../store/state/OneSong'


function Song(){

    const {id} = useParams();
   /*  const dispatch = useDispatch()
    
    const song = useSelector((state) => state.Song) 
    const [songs, setsongs] = useState({})
    console.log(dispatch(oneSong()))
    //setsongs(dispatch(oneSong())) */
    return (
        <div>
            <Header />
        </div>
    )
}

export default Song