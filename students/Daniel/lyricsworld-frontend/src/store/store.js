import { configureStore } from "@reduxjs/toolkit";
import ArtistReducer from './state/ArtistsList.js'
import AlbumReducer from './state/AlbumList.js'
import RegisterSlice from './state/RegisterSlice.js'
import ProfileSlice from './state/ProfileSlice.js'
import LoginSlice from "./state/LoginSlice.js";
export const store = configureStore({
  reducer: {
    Artist: ArtistReducer,
    Album: AlbumReducer,
    User: RegisterSlice,
    Profile: ProfileSlice,
    Login: LoginSlice
}});
