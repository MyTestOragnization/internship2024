import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const getSongs = createAsyncThunk('songs/fetch', async () => {
    const Iresponse = await axios.get("http://localhost:5159/api/Songs/GetSong/")
    return Iresponse.data
})

export const SongList = createSlice({
    name: "song",
    initialState:
    {
        data: [],
        error: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(getSongs.pending, () => {console.log("fetching data")})
        .addCase(getSongs.fulfilled, (state, action) => {state.data =action.payload})
    }
})

export default SongList.reducer