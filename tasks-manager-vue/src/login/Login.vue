<template>
  <div class="background"></div>
  <div class="login">
    <div style="display: flex; opacity: 1; z-index: 3;">
      <h1 class="ml-6" style="color: #daa520;">IT</h1>
      <h1 class="">ACTOS</h1>
    </div>
    
    <v-card class="card mx-auto px-6 py-8" rounded elevation="3">
      <span>Login</span>
      <v-form
        v-model="form"
        @submit.prevent="onSubmit">
        <v-text-field
          min-width="300"
          v-model="email"
          :readonly="loading"
          :rules="[required]"
          class="mb-2 form"
          label="Email"
          clearable
        ></v-text-field>

        <v-text-field
          v-model="password"
          :readonly="loading"
          :rules="[required]"
          label="Password"
          placeholder="Enter your password"
          clearable
        ></v-text-field>

        <a href="">Click here</a>

        <br>

        <v-btn
          :disabled="!form"
          :loading="loading"
          color="success"
          size="large"
          type="submit"
          variant="elevated"
          block
        >
          <span class="mt-7">
            Sign In
          </span>
        </v-btn>
      </v-form>

      </v-card>

      <v-btn @click="getMessage">
        Request Test
      </v-btn>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import { useAuthStore } from '../stores/AuthStore'
import axios from 'axios'

const authUser = useAuthStore()

let form = ref(false)
let email = ref(null)
let password = ref(null)
let loading = ref(false)

const onSubmit = () => {
  if (!form) return

  loading.value = true

  setTimeout(() => {
    loading.value = false
    authUser.setUserAuthenticated(true)
  }, 1500)

}

const required = (v) => {
  return !!v || 'Field is required'
}


const getMessage = () => {
  axios.defaults.baseURL = 'http://localhost:5262/v1/'

  axios.get('user/test/2')
    .then(res => {
      console.log('status: ', res.status)
      console.log('statusText: ', res.statusText)
      console.log('message: ', res.data)
    })
    .catch(err => {
      if (err.response.status == 400) {
        console.log('status: ', err.response.status)
        console.log('statusText: ', err.response.statusText)
        console.log('message: ', err.response.data)
      }
      else if (err.response.status == 500) {
        console.log('status: ', err.response.status)
        console.log('statusText: ', err.response.statusText)
      }
      else 
        console.log(err)
    })
}

</script>

<style>
.card {
  /* opacity: 0.8; */
  /* background-color: #303030; */
  padding: 10px;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 64vh;
  font-size: 2.5rem;
  z-index: 1;
}

/* .form {
  opacity: 1.0;
  z-index: 2;
} */

.card span {
  margin-bottom: 15px;
}

@media (min-width: 1024px) {
  .login {
    min-height: 100vh;
    display: flex;
    flex-direction: column;
    gap: 10px;
    align-items: center;
    /* justify-content: center; */
    margin-top: 10vh;
    font-size: 2rem;
    font-weight: lighter;
  
  }
}

/* .background {
  width: 100%;
  height: 100vh;
  background-image: url("C:\edu\projects\user-authentication-vue\user-authentication-vue\src\assets\images\logoLeao.jpeg");
} */

.background {
    opacity: 0.5;
    background-image: url("C:\edu\projects\user-authentication-vue\user-authentication-vue\src\assets\images\logoLeao.jpeg"); /* Caminho para a imagem */
    background-size: cover; /* Ajusta o tamanho da imagem para cobrir a tela */
    background-position: center; /* Centraliza a imagem */
    background-repeat: no-repeat; /* Evita que a imagem se repita */
    height: 100%;
    width: 100%;
    position: fixed; 
    /* Mantém a imagem fixa no fundo */
    z-index: 1; 
    /* Coloca a imagem atrás de outros elem */
}
</style>
  