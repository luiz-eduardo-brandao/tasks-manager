<template>
  <div class="background"></div>
  <div class="login">
    <div style="display: flex; opacity: 1; z-index: 3;">
      <h1 class="ml-2" style="color: #daa520;">TASKS</h1>
      <h1 class="">MANAGER</h1>
    </div>
    
    <v-card class="card px-10 py-10" rounded elevation="5">
      <div class="head-text mb-5 text-center">
        Faça login na sua conta!
      </div>
      <v-form
        v-model="form"
        @submit.prevent="login">
        <v-text-field
          min-width="300"
          v-model="email"
          :readonly="loading"
          :rules="[(v) => !!v || 'Favor informar email']"
          class="mb-2 form"
          label="Email"
          clearable
        ></v-text-field>

        <v-text-field
          v-model="password"
          :readonly="loading"
          :rules="[(v) => !!v || 'Favor informar senha']"
          label="Senha"
          placeholder="Entre com sua senha"
          clearable
        ></v-text-field>

        <div class="link-registration mt-2">
          Não tem uma conta? <a href="/register" class="ml-1">Cadastre-se</a>
        </div>

        <br>

        <v-btn
          :loading="loading"
          color="success"
          size="large"
          type="submit"
          variant="elevated"
          block
        >
          <span class="mt-7">
            Fazer Login
          </span>
        </v-btn>
      </v-form>

      <br>
      <v-divider></v-divider>
      <div class="subhead-text mt-8 mb-5 text-center">
        Outras opções de login:
      </div>
      <div class="text-center">
        <v-btn
          key="mdi-google"
          icon="mdi-google"
          class="mx-4 mb-5 mt-2"
          color="#daa520"
        >
          <v-icon class="mt-3 mx-auto">mdi-google</v-icon>
        </v-btn>
        <v-btn
          key="mdi-facebook"
          icon
          class="mx-4 mb-5 mt-2"
          color="#daa520"
          small
        >
          <v-icon class="mt-3 mx-auto">mdi-facebook</v-icon>
        </v-btn>
        <v-btn
          key="mdi-instagram"
          icon
          class="mx-4 mb-5 mt-2"
          color="#daa520"
        >
          <v-icon class="mt-3 mx-auto">mdi-instagram</v-icon>
        </v-btn>
      </div>
    </v-card>
  </div>
</template>

<script setup>
import { useAuthStore } from '../../stores/AuthStore'
import { useRouter } from 'vue-router';
import { ref } from 'vue'
import userService from '@/services/userService.js'

const router = useRouter()

const callRoute = (routeName) => router.push(routeName)

const authUser = useAuthStore()

let form = ref(false)
let email = ref(null)
let password = ref(null)
let loading = ref(false)

const login = async () => {
  if (!form) return

  if (!email.value || email.value == '') return
  if (!password.value || password.value == '') return

  try {
    loading.value = true
    
    var request = {
      userName: email.value,
      password: password.value
    }

    var result = await userService.login(request)

    console.log('result: ', result)

    authUser.setUserAuthenticated(true)
    authUser.setUser(result)

    callRoute('/')
  } catch (error) {
    alert(error.response.data.error)
  } finally {
    loading.value = false

  }
}
</script>

<style>
.link-registration {
  font-size: small;
  display: flex;
  justify-content: center;
}

.head-text {
  display: flex;
  justify-content: center;
  font-size: 1.8rem;
}

.subhead-text {
  font-size: 1rem;
}

.card {
  /* opacity: 0.9; */
  /* background-color: #030712; */
  padding: 10px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  /* align-items: center; */
  width: 70vh;
  font-size: 2.5rem;
  /* z-index: 1; */
}

/* .form {
  opacity: 1.0;
  z-index: 2;
} */

.card span {
  margin-bottom: 15px;
}


.login {
  padding-top: 10vh;
  padding-bottom: 10vh;
  min-height: 100vh;
  display: flex;
  flex-direction: row;
  /* gap: 10vh; */
  align-items: center;
  justify-content: center;
  font-size: 1.2rem;
  font-weight: lighter;
}


/* .background {
  width: 100%;
  height: 100vh;
  background-image: url("C:\edu\projects\user-authentication-vue\user-authentication-vue\src\assets\images\logoLeao.jpeg");
} */

.background {
    opacity: 0.1;
    background-image: url("C:\edu\projects\user-authentication-vue\user-authentication-vue\src\assets\images\logoLeao.jpeg"); /* Caminho para a imagem */
    background-size: cover; /* Ajusta o tamanho da imagem para cobrir a tela */
    background-position: center; /* Centraliza a imagem */
    background-repeat: no-repeat; /* Evita que a imagem se repita */
    height: 100%;
    width: 100%;
    position: fixed; 
    /* Mantém a imagem fixa no fundo */
    /* z-index: 1;  */
    /* Coloca a imagem atrás de outros elem */
}
</style>
  