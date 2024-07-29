import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";
import { act } from "react";

const GetProfile = createAsyncThunk('GetProfile/fetch', async (id) => 
    {
        let currId = id
        const response = axios.get("http://localhost:5159/api/User/GetUser/", {params: {id: currId}})
    })

export const ProfileSlice = createSlice({
    name: "profile",
    initialState:
    {
        username: '',
        isLogged: false,
        error: '',
        token: ''
    },
    reducers: 
    {
        changeLogged(state){
            state.isLogged = !state.isLogged
        },
        setUsername(state, action){
            state.username = action.payload
        }
    },
    extraReducers(builder){
        builder
        .addCase(GetProfile.pending, ()=> console.log("pending"))
        .addCase(GetProfile.fulfilled,(state,action)=> {state.username=action.payload.username})
    }
    
})


export const {changeLogged,setUsername} = ProfileSlice.actions
export default ProfileSlice.reducer