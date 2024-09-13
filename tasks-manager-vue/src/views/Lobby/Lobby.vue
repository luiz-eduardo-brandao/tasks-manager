<template>
    <div class="background"></div>
    <div>
        <Header />
        <v-main>  
            <v-container >
                <RouterView />
            </v-container>

            <!-- <Footer /> -->
        </v-main>
    </div>
</template>
  
<script setup>
import { useAuthStore } from '../../stores/AuthStore'
import { useRouter } from 'vue-router';
import { ref } from 'vue'
import axios from 'axios'
import Header from '@/components/Header.vue';
import Footer from '@/components/Footer.vue';
import HomeView from '../HomeView.vue';
  
  const router = useRouter()
  
  const callRoute = (routeName) => router.push(routeName)
  
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
    /* width: 75vh; */
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
    