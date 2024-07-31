import Header from './Header'
import css from '../cssformodules/SongsPage.css'
import { useState } from 'react'
import axios from 'axios';
function SongsPage(){

    const [value, setValue] = useState('');

    
    const result = () => 
    {
        var returnvalue = axios.get("http://localhost:5159/api/Song/GetSongByTitle/"+{value})
        return returnvalue.data
    }

    const handleChange = (e) =>     
    {

        setValue(e.target.value)

    }



    return(
        <div id="pagecontainer">
            <Header />
            <main>
                <input type='text' name="search" id="search" placeholder="Search for songs..." value={value} onChange={handleChange}></input>
                <button onClick={result}>y</button>
            </main>
        </div>
    )
}

export default SongsPage