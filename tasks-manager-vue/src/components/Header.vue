<template>
    <v-app-bar class="header">
      <v-app-bar-nav-icon  v-show="props.userAuthenticated" @click="drawerStore.toggleDrawer"></v-app-bar-nav-icon>

        <div 
          @click="callRoute('/')"
          class="logo ml-6 px-6"
          variant="text">
          <h1 style="color: #daa520;">TASKS</h1>
          <h1 >MANAGER</h1>
        </div>

        <v-spacer></v-spacer>

        <v-btn 
          v-show="!props.userAuthenticated"
          @click="callRoute('/login')"
          class="mr-10"
        >
          Login
        </v-btn>

        <v-list-item v-show="props.userAuthenticated"
          prepend-avatar="https://cdn.vuetifyjs.com/images/john.png"
          :subtitle="user.user == undefined ? '' : user.user.collaborator.name"
          :title="user.user == undefined ? '' : user.user.userName"
        >
          <template v-slot:append>
            <!-- <v-btn
              icon="mdi-menu-down"
              size="small"
              variant="text"
            ></v-btn> -->
            <v-menu
              min-width="150px"
              rounded
            >
              <template v-slot:activator="{ props }">
                <v-btn
                  v-bind="props"
                  icon="mdi-menu-down"
                  size="small"
                  variant="text"
                ></v-btn>
              </template>

              <v-card class="mt-5" >
                <v-card-text style="background-color: #3f3f46;">
                  <div class="mx-auto text-center my-2">
                    <!-- <v-avatar color="brown" >
                      <span class="text-h5">Initials</span>
                    </v-avatar> -->
                    <h3>{{ user.user == undefined ? '' : user.user.collaborator.name }}</h3>
                    <p class="text-caption mt-1">
                      {{ user.user == undefined ? '' : user.user.userName }}
                    </p>
                    <!-- <v-divider class="my-3"></v-divider> -->
                    <!-- <v-btn
                      variant="text"
                      rounded
                      @click="callRoute('/profile')"
                    >
                      Perfil
                    </v-btn> -->
                    <v-divider class="my-3"></v-divider>
                    <v-btn
                      variant="text"
                      rounded
                      @click="logout"
                    >
                      <v-icon class="mr-2">mdi mdi-logout</v-icon>
                      Sair
                    </v-btn>
                  </div>
                </v-card-text>
              </v-card>
            </v-menu>
          </template>
        </v-list-item>
    </v-app-bar>
</template>
  
<script setup>
import { useRouter} from 'vue-router'
import { useDrawerStore } from '../stores/DrawerStore'
import { useAuthStore } from '../stores/AuthStore'
import { computed } from 'vue'

const props = defineProps(['userAuthenticated'])

const drawerStore = useDrawerStore()
const authUser = useAuthStore()
const router = useRouter()

const callRoute = (routeName) => router.push(routeName)

const logout = () => {

  setTimeout(() => {
    // loading.value = false
    authUser.setUserAuthenticated(false)

    callRoute('/')
  }, 1500)
}

const user = computed(() => {
  return authUser.user
})

</script>

<style>
.header {
    display: flex;
    justify-content: center;
    height: 80px;
    background-color: #020617;
}

.logo {
  display: flex;
  
}

.logo:hover {
  cursor: pointer;
}
</style>