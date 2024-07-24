import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const getArtists = createAsyncThunk('artist/fetch', async () => { 
    const Iresponse = await axios.get("http://localhost:5159/api/Artists/GetArtist/")
    .then(response => {Iresponse=response.data})
    .catch(error => {return error})
    return Iresponse
})

export const ArtistsList = createSlice({
    name: "artist",
    initialState: 
    {
        data: [],
    },
    extraReducers: (builder) => {
        builder
        .addCase(getArtists.pending, () => {console.log("fetching data")})
        .addCase(getArtists.fulfilled, (state, action) => {return action.payload})
    }    
})

export default ArtistsList.reducer