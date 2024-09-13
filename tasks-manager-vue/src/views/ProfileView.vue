<template>
  <div class="profile">
    <v-app id="inspire" 
    >
      <v-navigation-drawer color="grey-lighten-4" v-model="drawer">
        <v-sheet
          class="pa-4"
          color="grey-lighten-4"
          style="display: flex; flex-direction: column; justify-content: center; align-items: center;"
        >
          <v-avatar
            class="mb-4"
            color="grey-darken-1"
            size="64"
          ></v-avatar>

          <div>john@google.com</div>
        </v-sheet>

        <v-divider></v-divider>

        <v-list class="mt-10">
          <v-list-item
            v-for="[icon, text] in links"
            :key="icon"
            :prepend-icon="icon"
            :title="text"
            link
          ></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <v-main style="background-color: gray;" color="grey-lighten-4">
        <v-container
          class="py-8 px-6"
          fluid
          >
          <div class="text-center mb-6" style="display: flex; flex-direction: column;">
            <h1>Perfil</h1>
            <span>Adicione informações sobre você!</span>
          </div>

          <v-form
          @submit.prevent=""
            >
                <v-text-field
                    min-width="300"
                    class="mb-2 form"
                    label="Nome"
                    clearable
                ></v-text-field>

                <v-text-field
                    min-width="300"
                    class="mb-2 form"
                    label="Sobrenome"
                    clearable
                ></v-text-field>

                <div style="display: flex; justify-content: center; gap: 10px; ">
                    <v-text-field
                        class="mb-2 form"
                        label="Telefone"
                        clearable
                    ></v-text-field>
                    <v-text-field
                        class="mb-2 form"
                        label="Cep"
                        clearable
                    ></v-text-field>

                </div>

                <v-text-field
                    min-width="300"
                    class="mb-2 form"
                    label="Email"
                    clearable
                ></v-text-field>
        
                <br>
        
                <v-btn
                    color="#daa520"
                    style="color: #fff;"
                    size="large"
                    type="submit"
                    variant="elevated"
                    block
                >
                    <span class="">
                    Salvar Alterações
                    </span>
                </v-btn>

            </v-form>
        </v-container>
      </v-main>
    </v-app>
  </div>
</template>

<script setup>
import { ref } from 'vue'

  const cards = ref(['Today', 'Yesterday'])
  const links = ref([
    ['mdi-inbox-arrow-down', 'Inbox'],
    ['mdi-send', 'Send'],
    ['mdi-delete', 'Trash'],
    ['mdi-alert-octagon', 'Spam'],
  ])

  const drawer = ref(null)
</script>

<style>
@media (min-width: 1024px) {
  .profile {
    min-height: 100vh;
    display: flex;
    align-items: flex-start;
    padding-top: 20px;
  }
}
</style>
