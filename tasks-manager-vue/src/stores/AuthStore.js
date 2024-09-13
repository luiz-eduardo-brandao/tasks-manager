import { defineStore } from 'pinia'
import { ref } from 'vue'

export const useAuthStore = defineStore('auth', () => {
    let userAuthenticated = ref(false)

    let user = ref({})

    const setUserAuthenticated = (status) => {
        console.log('setUserAuthenticated', status)

        userAuthenticated.value = status
    }

    const setUser = (payload) => {
        
        user.value = payload
    }

    // async function checkToken() {
    //     try {
    //         // const token = 'Bearer ' + autorizationToken
    //         // const { data } = await http.get('/auth/verify', {
    //         //     headers: {
    //         //         Authorization: token
    //         //     }
    //         // })

    //         // return data

    //     } catch (error) {
    //         console.log(error.response.data)
    //     }
    // }

    return {
        userAuthenticated, setUserAuthenticated,
        user, setUser
    }
})