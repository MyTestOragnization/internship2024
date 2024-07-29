import React from "react";
import { useSelector,useDispatch } from 'react-redux';
import {getAlbums} from '../store/state/AlbumList'
import { useEffect } from "react";
import { getToken } from "../store/state/LoginSlice";
    

    function Album(){
        const login = useSelector((state)=> state.Login)
        const token = login.token
        const dispatch = useDispatch()
        useEffect(()=> {dispatch(getAlbums(token))},[])
        const album = useSelector((state) => state.Album)
        const albumItems = album.data.map((album) => <li key={album.albumID}>{album.albumTitle}</li>);
        console.log(album)
        return (
            <div>
                <ul>{albumItems}</ul>
            </div>
        );
}

export default Album

