import { defineStore } from 'pinia'
import { ref } from 'vue'

export const useLoadingStore = defineStore('loading', () => {
    let overlay = ref(false)

    const setOverlay = (status) => {
        console.log('setOverlay: ', status)

        overlay.value = status
    }

    return { overlay, setOverlay }
})