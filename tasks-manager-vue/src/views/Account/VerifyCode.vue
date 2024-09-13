<template>
    <div style="min-height: 80vh;">
        <v-card
         style="display: flex; flex-direction: column; justify-content: center;align-items: center;"
          class="py-8 px-6 text-center mx-auto ma-4 mt-15"
          elevation="12"
          max-width="600"
          height="500"
          width="100%"
        >
          <h3 class="text-h6 mb-4">Verify Your Account</h3>
      
          <div class="text-body-2">
            We sent a verification code to john..@gmail.com <br>
      
            Please check your email and paste the code below.
          </div>
      
          <v-sheet color="surface">
            <v-otp-input
              v-model="otp"
            ></v-otp-input>
          </v-sheet>
      
          <v-btn
            @click="verify"
            :loading="loading"
            class="my-4"
            color="purple"
            height="40"
            text="Verify"
            variant="flat"
            width="70%"
          ></v-btn>
      
          <div class="text-caption">
            Didn't receive the code? <a href="#" @click.prevent="otp = ''">Resend</a>
          </div>
        </v-card>
    </div>
</template>

<script setup>
import { ref } from 'vue';
import { useRouter } from 'vue-router';

let otp = ref('')
let loading = ref(false)

const router = useRouter()

const callRoute = (routeName) => router.push(routeName)

const verify = () => {
  loading.value = true
  
    setTimeout(() => {
      loading.value = false
      // authUser.setUserAuthenticated(true)
  
      callRoute('/login')
    }, 1500)
}


</script>