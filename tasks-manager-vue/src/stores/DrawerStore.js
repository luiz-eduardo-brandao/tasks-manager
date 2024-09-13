import { defineStore } from 'pinia'
import { ref } from 'vue'

export const useDrawerStore = defineStore('drawer', () => {
    let drawer = ref(true)

    const toggleDrawer = () => {
        console.log('toggleDrawer')

        drawer.value = !drawer.value
    }

    return {
        drawer, toggleDrawer
    }
})