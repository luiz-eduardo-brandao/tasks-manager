<script setup>
import Carousel from '@/components/Carousel.vue'
import Slide from '@/components/Slide.vue'
import TheWelcome from '../components/TheWelcome.vue'
import { useAuthStore } from '../stores/AuthStore'
import { useProjectStore } from '../stores/ProjectStore'
import { onMounted } from 'vue'


import projectService from '@/services/projectService.js'

const authUser = useAuthStore()
const projectStore = useProjectStore()

onMounted(async () => {
  let user = authUser.user
  console.log('user: ', user)

  let projects = await projectService.getProjects()

  console.log('projects: ', projects)

  projectStore.setProjectsList(projects)

})

</script>

<template>
  <div v-if="authUser.userAuthenticated" class="mt-10">
    <h1>Bem-vindo de volta!</h1>
    <h4 class="text-light">O que há de novo?</h4>
    <Carousel class="mt-9" />

    
    <!-- <h3 class="text-center mt-15">Comece por aqui!</h3> -->
    <!-- <Slide class="mt-3" />
    <br> -->
    <!-- <v-divider class="mt-8"></v-divider> -->
  </div>
  <div v-else>
    <div class="text-center mt-15"
      style="display: flex; justify-content: center; align-items: center">
      <h1 >Bem-vindo!</h1>
    </div>
    <div class="text-center"
      style="display: flex; justify-content: center; align-items: center">
      <h3>Crie sua conta e comece a navegar!</h3>
    </div>
    <v-divider class="mt-15"></v-divider>
  </div>
  <!-- <main class="home">
    <TheWelcome />
  </main> -->
</template>

<style>
@media (min-width: 1024px) {
  .home {
    min-height: 70vh;
    display: flex;
    align-items: center;
  }
}
</style>
