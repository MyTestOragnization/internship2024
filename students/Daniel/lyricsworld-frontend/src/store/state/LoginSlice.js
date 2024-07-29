import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const Login = createAsyncThunk('user/register', async (details) => {

    let username = details.username 
    let password = details.password

    const Iresponse = await axios.post("http://localhost:5159/api/User/Login/", 
    {
        username,
        password,   
    })
    return Iresponse.data
})


export const RegisterSlice = createSlice({
    name: "user",
    initialState:
    {
        username: '',
        error: '',
        token: ''
    },
    extraReducers: (builder) => {
        builder
        .addCase(Register.pending, () => {console.log("fetching data")})
        .addCase(Register.fulfilled, (state, action) => {state.username =action.payload.username;state.token=action.password.token; console.log(action.payload.username+" added")})
        .addCase(Register.rejected, (state,action)=> {state.error=action.error.message})
    }
})

export default RegisterSlice.reducer