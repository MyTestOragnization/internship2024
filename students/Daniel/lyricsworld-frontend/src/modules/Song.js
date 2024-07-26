import React from "react";
import { useSelector,useDispatch } from 'react-redux';
import {getSongs} from '../store/state/SongsList'
import { useEffect } from "react";
    

    function Song(){
        const dispatch = useDispatch()
        useEffect(()=> {dispatch(getSongs())},[])
        const song = useSelector((state) => state.Song)
        const SongItems = song.data.map((song) => <li key={song.songID}>{song.songTitle}</li>);
        console.log(song)
        return (
            <div>
                <ul>{SongItems}</ul>
            </div>
        );
}

export default Song

