import axios from 'axios'

const HTTPClient = axios.create({
    baseURL: 'http://localhost:5111/',
    headers: {
        'Content-Type': 'application/json'
    }
})

export default HTTPClient