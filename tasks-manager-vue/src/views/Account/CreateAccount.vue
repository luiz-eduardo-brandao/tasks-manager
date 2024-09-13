<template>
    <div class="background"></div>

    <VerifyCode  v-if="verifyCode"/>
    <div class="login" v-else>
      <div style="display: flex; opacity: 1; z-index: 3;">
        <h1 class="ml-6" style="color: #daa520;">TASKS</h1>
        <h1 class="">MANAGER</h1>
      </div>
      
      <v-card class="card px-8 py-10" rounded elevation="5">
          <div class="head-text mb-5 text-center">
          Crie sua conta na IT Actos
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
                  label="Nome"
                  clearable
              ></v-text-field>

              <v-text-field
                  min-width="300"
                  v-model="email"
                  :readonly="loading"
                  :rules="[required]"
                  class="mb-2 form"
                  label="Sobrenome"
                  clearable
              ></v-text-field>

              <div style="display: flex; justify-content: center; gap: 10px; ">
                  <v-text-field
                      v-model="email"
                      :readonly="loading"
                      :rules="[required]"
                      class="mb-2 form"
                      label="Telefone"
                      clearable
                  ></v-text-field>
                  <v-text-field
                      v-model="email"
                      :readonly="loading"
                      :rules="[required]"
                      class="mb-2 form"
                      label="Cep"
                      clearable
                  ></v-text-field>

              </div>

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
                  label="Senha"
                  placeholder="Entre com sua senha"
                  clearable
              ></v-text-field>

              <v-text-field
                  v-model="password"
                  :readonly="loading"
                  :rules="[required]"
                  label="Confirmar Senha"
                  placeholder="Entre com sua senha"
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
                  Criar Conta
                  </span>
              </v-btn>

              <br>

              <div class="link-registration text-center">
                  <div>
                      Ao se inscrever, você concorda com nossos <a href="" target="_blank">Termos de Uso</a> e com a <a href="" target="_blank">Política de Privacidade</a>.
                  </div>
              </div>

              <br>

              <div class="link-registration text-center" style="font-size: 1.2rem;">
                  <div>
                      Já tem uma conta? <a href="/login" style="font-weight: bold;">Fazer login</a>
                  </div>
              </div>
          </v-form>
      </v-card>
    </div>

</template>
  
<script setup>
import { useAuthStore } from '../../stores/AuthStore'
import { useRouter } from 'vue-router';
import { ref } from 'vue'
import axios from 'axios'
import VerifyCode from './VerifyCode.vue';
  
const router = useRouter()

const callRoute = (routeName) => router.push(routeName)

const authUser = useAuthStore()

let form = ref(false)
let email = ref(null)
let password = ref(null)
let loading = ref(false)
let verifyCode = ref(false)

const onSubmit = () => {
  if (!form) return

  verifyCode.value = true

  // loading.value = true

  // setTimeout(() => {
  //   loading.value = false
  //   // authUser.setUserAuthenticated(true)

  //   callRoute('/login')
  // }, 1500)

}

const required = (v) => {
  return !!v || 'Field is required'
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
    padding-top: 5vh;
    padding-bottom: 10vh;
    min-height: 85vh;
    display: flex;
    flex-direction: row;
    gap: 10vh;
    align-items: center;
    justify-content: center;
    font-size: 2rem;
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
    