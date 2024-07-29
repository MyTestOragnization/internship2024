import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const Login = createAsyncThunk('login', async (details) => {

    let username = details.username 
    let password = details.password

    const Iresponse = await axios.post("http://localhost:5159/api/User/Login/", 
    {
        username,
        password,   
    })
    return Iresponse.data
})


export const LoginSlice = createSlice({
    name: "userLogin",
    initialState:
    {
        username: '',
        error: '',
        token: ''
    },
    reducers: {
        getToken(state){
            return state.token
        }
    },
    extraReducers: (builder) => {
        builder
        .addCase(Login.pending, () => {console.log("fetching data")})
        .addCase(Login.fulfilled, (state, action) => {state.username =action.payload.username;state.token=action.payload.jwt; })
        .addCase(Login.rejected, (state,action)=> {state.error=action.error.message})
    }
})
export const {getToken} = LoginSlice.actions
export default LoginSlice.reducer