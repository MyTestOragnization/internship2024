import './App.css';
import Header from "./modules/Header"
import React, {useEffect} from 'react';
import Artist from './modules/Artist'
import Album from './modules/Album'
import Song from './modules/Song'
function App() {
  
  return (
    <div className="App">
      <Header />
      <main>
        <h1>LyricsWorld</h1>
        <h2>Music, the Coolest Language of All</h2>
        <a>Start Searching</a>
      <Artist /> 
      <Album />
      <Song />
      </main> 
     
    </div>
      );
}

export default App;
