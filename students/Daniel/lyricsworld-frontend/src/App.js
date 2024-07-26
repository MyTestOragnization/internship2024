import './App.css';
import Header from "./modules/Header"
import React, {useEffect} from 'react';
import Artist from './modules/Artist'
import Album from './modules/Album'
import Song from './modules/Song'
import RegisterPage from './modules/RegisterPage'
import HomePage from './modules/HomePage';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

function App() {
  
  return (
    <Routes>
      <Route exact path='/' element={<HomePage />} />
      <Route exact path='/register' element={<RegisterPage />} />
    </Routes>
      );
}

export default App;
