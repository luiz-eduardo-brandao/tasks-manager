<template>
    <v-navigation-drawer 
        class="navigation"
        v-model="drawerStore.drawer"
        elevation="5"
        width="350"
        min-width="250"
        max-width="350"
    >
      <!--  -->
      <div class="mx-3 my-3 px-3">
        <br>
        <v-list>
          <v-list-item
            color="primary"
            rounded="shaped"
            :value="'home'"
          >
            <template v-slot:prepend>
              <v-icon icon="mdi mdi-home-outline" color="#daa520"></v-icon>
            </template>

            <v-list-item-title @click="callRoute('/')" v-text="'Home'"></v-list-item-title>
          </v-list-item>

          <v-list-item
            color="primary"
            rounded="shaped"
            :value="'criarProjeto'"
          >
            <template v-slot:prepend>
              <v-icon icon="mdi mdi-check-circle" color="#daa520"></v-icon>
            </template>

            <v-list-item-title @click="callRoute('/createProject')" v-text="'Criar Projeto'"></v-list-item-title>
          </v-list-item>

          <v-list-group value="Projetos">
            <template v-slot:activator="{ props }">
              <v-list-item
                v-bind="props"
                title="Projetos"
              >
              <template v-slot:prepend>
              <v-icon icon="mdi mdi-folder" color="#daa520"></v-icon>
            </template>
            </v-list-item>
            </template>

            <v-list-item
              v-for="(project, i) in projectsList"
              :key="project.id"
              :title="project.name"
              :value="project"
              @click="callRoute('/project'); openProject(project)"
            >
              <v-list-item-title @click="callRoute('/project')"></v-list-item-title>
            </v-list-item>
          </v-list-group>
        </v-list>
      </div>
    </v-navigation-drawer>
</template>

<script setup>
import { useDrawerStore } from '../stores/DrawerStore'
import { useProjectStore } from '../stores/ProjectStore'
import { ref, computed } from 'vue';
import { useRouter } from 'vue-router'

const drawerStore = useDrawerStore()
const projectStore = useProjectStore()

// let projectsList = projectStore.projects

const projectsList = computed(() => {
  return projectStore.projects
})

console.log('projectsList: ', projectsList[0])

const router = useRouter()

const callRoute = (routeName) => router.push(routeName)

const openProject = (project) => {
  console.log('openProject: ', project)

  projectStore.setProject(project)
}


const  admins = ref([
        ['Projeto 1', 'mdi-account-multiple-outline'],
        ['Projeto 2', 'mdi-cog-outline'],
        ['Projeto 3', 'mdi-cog-outline'],
        ['Projeto 4', 'mdi-cog-outline'],
        ['Projeto 5', 'mdi-cog-outline'],
      ])


const items = ref([
    { text: 'Home', icon: 'mdi mdi-home-outline', route: '/' },
    { text: 'Projetos', icon: 'mdi mdi-folder', route: '/about' },
])

const items2 = ref([
    { text: 'My Files', icon: 'mdi-folder' },
    { text: 'Shared with me', icon: 'mdi-account-multiple' },
    { text: 'Starred', icon: 'mdi-star' },
    { text: 'Recent', icon: 'mdi-history' },
    { text: 'Offline', icon: 'mdi-check-circle' },
    { text: 'Uploads', icon: 'mdi-upload' },
    { text: 'Backups', icon: 'mdi-cloud-upload' },
])
</script>

<style>

.navigation {
    background-color: #3f3f46;
    color: #fff;
}
</style>