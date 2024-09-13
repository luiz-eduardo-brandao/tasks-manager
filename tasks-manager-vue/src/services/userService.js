import HTTPClient from '@/configuration/axios.js'

export default {
    login: async payload => {
        const { data } = await HTTPClient.post('users/login', payload)
        return data
    },
}