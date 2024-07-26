import { configureStore } from "@reduxjs/toolkit";
import ArtistReducer from './state/ArtistsList.js'
import AlbumReducer from './state/AlbumList.js'
export const store = configureStore({
  reducer: {
    Artist: ArtistReducer,
    Album: AlbumReducer
  },
  
});
