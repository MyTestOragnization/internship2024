import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import api from "../../smallApi/axiosApi";

export const oneSong = createAsyncThunk('oneSong', async (details) => {

    let value = details 
    const Iresponse = await api.get("http://localhost:5159/api/Song/GetSong/"+value)
    return Iresponse.data
})


export const Song = createSlice({
    name: "oneSong",
    initialState:
    {
        song: {},
        error: '',
    },
    extraReducers: (builder) => {
        builder
        .addCase(oneSong.pending, () => {console.log("searching for song")})
        .addCase(oneSong.fulfilled, (state, action) => {state.song = action.payload})
        .addCase(oneSong.rejected, (state,action)=> {state.song = {}})
    }
})
export default Song.reducer