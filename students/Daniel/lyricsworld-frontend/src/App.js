import logo from './logo.svg'
import './App.css';
import Header from "./modules/Header"
import React, {useEffect} from 'react';
import { useSelector,useDispatch } from 'react-redux';
import {getArtists} from './store/state/ArtistsList'

function App() {
  
  const artist = useSelector((state) => state.Artist)
  const dispatch = useDispatch()
  useEffect(()=>{dispatch(getArtists())},[])
  console.log(artist.data)
  
  return (
    <div className="App">
      <Header />
      <main>
        <h1>LyricsWorld</h1>
        <h2>Music, the Coolest Language of All</h2>
        <a>Start Searching</a>
      </main>
      
    </div>
      );
}

export default App;
