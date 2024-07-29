import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

<<<<<<< HEAD
export const getAlbums = createAsyncThunk('album/fetch', async () => {
    const Iresponse = await axios.get("http://localhost:5159/api/Albums/GetAlbums/", {headers: {"Authorization": "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiZGFuaWVsdGVzdGFkbWluIiwiZXhwIjoxNzIyMjkwNDAwLCJpc3MiOiJodHRwOi8vbG9jYWxob3N0OjMwMDUiLCJhdWQiOiJodHRwOi8vbG9jYWxob3N0OjMwMDUifQ.YdmbRBoHCQc6jUhEQ2282Hz5VunxXSqsNxhjBLkrD7A"}})
=======
export const getAlbums = createAsyncThunk('artist/fetch', async () => {
    const Iresponse = await axios.get("http://localhost:5159/api/Albums/GetAlbums/")
>>>>>>> 3bdd92718a119df286ba0a38c68560aed95af3c5
    return Iresponse.data
})

export const AlbumList = createSlice({
    name: "album",
    initialState:
    {
        data: [],
        error: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(getAlbums.pending, () => {console.log("fetching data")})
        .addCase(getAlbums.fulfilled, (state, action) => {state.data =action.payload})
    }
})

export default AlbumList.reducer