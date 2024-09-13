<template>
    <div class="login">
      <v-card class="card px-8 py-10" rounded elevation="5">
          <div class="head-text mb-5 text-center">
          Crie seu Projeto aqui!
          </div>
          <v-form
          v-model="form"
          @submit.prevent="onSubmit"
          >
              <v-text-field
                  min-width="300"
                  v-model="email"
                  :readonly="loading"
                  :rules="[required]"
                  class="mb-2 form"
                  label="Nome do projeto"
                  clearable
              ></v-text-field>
      
              <br>
      
              <v-btn
                  :loading="loading"
                  color="#daa520"
                  style="color: #fff;"
                  size="large"
                  type="submit"
                  variant="elevated"
                  block
              >
                  <span class="mt-7">
                  Criar Projeto
                  </span>
              </v-btn>
          </v-form>
      </v-card>
    </div>

</template>
  
<script setup>
import { useAuthStore } from '../stores/AuthStore'
import { useRouter } from 'vue-router';
import { ref } from 'vue'
import axios from 'axios'

const router = useRouter()

const callRoute = (routeName) => router.push(routeName)

const authUser = useAuthStore()

let form = ref(false)
let email = ref(null)
let password = ref(null)
let loading = ref(false)
const onSubmit = () => {
  if (!form) return

//   verifyCode.value = true

  // loading.value = true

  // setTimeout(() => {
  //   loading.value = false
  //   // authUser.setUserAuthenticated(true)

  //   callRoute('/login')
  // }, 1500)

}

const required = (v) => {
  return !!v || 'Campo obrigatório'
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
    width: 80vh;
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
    min-height: 100vh;
    padding-bottom: 50vh;
    /* min-height: 100vh; */
    display: flex;
    flex-direction: row;
    /* gap: 10vh; */
    align-items: center;
    justify-content: center;
    font-size: 2rem;
    font-weight: lighter;
  }

  </style>
    