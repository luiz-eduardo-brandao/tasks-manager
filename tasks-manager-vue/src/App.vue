
<template>
  <v-app v-if="!authUser.userAuthenticated">
    <Lobby />
  </v-app>
    
  <v-app id="inspire" style="background-color: #fff; color: black" v-else>
    <Header :userAuthenticated="true" />
    <Navigation />

    <v-main>  
      <v-container >
        <RouterView />
      </v-container>

      <!-- <Footer /> -->
    </v-main>
  </v-app>
</template>

<script setup>
  import { useAuthStore } from './stores/AuthStore'
  import Login from './views/Account/Login.vue'
  import CreateAccount from './views/Account/CreateAccount.vue'
  import Header from './components/Header.vue'
  import Navigation from './components/Navigation.vue'
  import Footer from './components/Footer.vue'
  import Loading from './components/Loading.vue'
  import Lobby from './views/Lobby/Lobby.vue'

  const authUser = useAuthStore()
</script>


