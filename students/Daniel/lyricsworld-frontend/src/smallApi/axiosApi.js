import axios from "axios";

axios.defaults.headers.common['Authorization'] = 'Bearer '+localStorage.getItem('token')
axios.defaults.headers.common['Content-Type'] = 'application/json'
export const baseURL = "http://localhost:5159/api"
const api = axios;

export default api

