import HTTPClient from '@/configuration/axios.js'

export default {
    getProjects: async () => {
        const { data } = await HTTPClient.get('projects')
        return data
    },
}