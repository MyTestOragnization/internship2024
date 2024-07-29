import './App.css';
import Album from './modules/Album'
import RegisterPage from './modules/RegisterPage'
import HomePage from './modules/HomePage'
import Profile from './modules/Profile'
import LoginPage from './modules/LoginPage'
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';

function App() {
  
  return (
    <Router>
    <Routes>
      <Route exact path='/' element={<HomePage />} />
      <Route exact path='/register' element={<RegisterPage />} />
      <Route exact path='/login' element={<LoginPage/>} />
      <Route exact path='/profile' element={<Profile />} /> 
      <Route exact path='/albums' element={<Album />} /> 
    </Routes>
    </Router>
  );
}

export default App;
