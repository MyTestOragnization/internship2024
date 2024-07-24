import { configureStore } from "@reduxjs/toolkit";
import reducer from './state/ArtistsList.js'

export const store = configureStore({
  reducer: {
    Artist: reducer
  },
  
});
