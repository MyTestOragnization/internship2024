import './App.css';
import Header from "./modules/Header"
import React, {useEffect} from 'react';
import Artist from './modules/Artist'
import Album from './modules/Album'
<<<<<<< HEAD
import Song from './modules/Song'
import RegisterPage from './modules/RegisterPage'
import HomePage from './modules/HomePage';
import Profile from './modules/Profile'
import LoginPage from './modules/LoginPage'
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

function App() {
  
  return (
    <Routes>
      <Route exact path='/' element={<HomePage />} />
      <Route exact path='/register' element={<RegisterPage />} />
      <Route exact path='/login' element={<LoginPage/>} />
      <Route exact path='/profile' element={<Profile />} /> 
      <Route exact path='/album' element={<Album />} /> 
    </Routes>
=======
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
      </main> 
     
    </div>
>>>>>>> 3bdd92718a119df286ba0a38c68560aed95af3c5
      );
}

export default App;
