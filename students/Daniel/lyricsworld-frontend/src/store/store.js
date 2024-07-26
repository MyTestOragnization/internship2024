import { configureStore } from "@reduxjs/toolkit";
import ArtistReducer from './state/ArtistsList.js'
import AlbumReducer from './state/AlbumList.js'
import SongReducer from './state/SongsList.js'


export const store = configureStore({
  reducer: {
    Artist: ArtistReducer,
    Album: AlbumReducer,
    Song: SongReducer
  },
  
});
