import { configureStore } from "@reduxjs/toolkit";
import ArtistReducer from './state/ArtistsList.js'
import AlbumReducer from './state/AlbumList.js'
<<<<<<< HEAD
import SongReducer from './state/SongsList.js'
import RegisterSlice from './state/RegisterSlice.js'
import ProfileSlice from './state/ProfileSlice.js'

export const store = configureStore({
  reducer: {
    Artist: ArtistReducer,
    Album: AlbumReducer,
    Song: SongReducer,
    User: RegisterSlice,
    Profile: ProfileSlice
=======
export const store = configureStore({
  reducer: {
    Artist: ArtistReducer,
    Album: AlbumReducer
>>>>>>> 3bdd92718a119df286ba0a38c68560aed95af3c5
  },
  
});
