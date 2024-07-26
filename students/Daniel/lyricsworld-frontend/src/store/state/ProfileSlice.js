import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
/* import axios from "axios"; */


export const UserSlice = createSlice({
    name: "profile",
    initialState:
    {
        username: '',
        isLogged: false,
        error: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(Register.pending, () => {console.log("fetching data")})
        .addCase(Register.fulfilled, (state, action) => {state.username =action.payload.username; console.log(action.payload.username+" added")})
        .addCase(Register.rejected, (state,action)=> {state.error=action.error.message})
    }
})

export default UserSlice.reducer