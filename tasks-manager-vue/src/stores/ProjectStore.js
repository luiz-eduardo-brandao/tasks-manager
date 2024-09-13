import { defineStore } from 'pinia'
import { ref } from 'vue'

export const useProjectStore = defineStore('project', () => {
    let projects = ref([])
    
    let project = ref({})
    let tasks = ref([])

    const setProjectsList = (payload) => {
        console.log('setProjectsList', payload)

        projects.value = payload
    }

    const setProject = (payload) => {
        console.log('setProject', payload)

        project.value = payload
        tasks.value = payload.tasks
    }

    return {
        projects, setProjectsList, setProject, tasks, project
    }
})