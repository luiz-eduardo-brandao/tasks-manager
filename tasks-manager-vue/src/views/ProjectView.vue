<template>
    <div class="content">
        <div class="text-center mt-15" style="display: flex; justify-content: center; align-items: center">
            <h1>{{ project.name }}</h1>
            <v-btn class="ml-7" color="#daa520" style="color: #fff;" @click="dialog = true">Criar Task</v-btn>
            <v-btn class="ml-7" color="red" style="color: #fff;">Excluir Projeto</v-btn>
        </div>
        <v-divider class="mt-5"></v-divider>

        <v-dialog
            v-model="dialog"
            max-width="400"
            persistent
            >
            <v-card class="card px-8 py-10" rounded elevation="5">
                <div class="head-text mb-5 text-center">
                    Crie uma Task
                </div>
                <v-form
                >
                    <v-text-field
                        min-width="300"
                        v-model="email"
                        :readonly="loading"
                        :rules="[required]"
                        class="mb-2 form"
                        label="Titulo"
                        clearable
                    ></v-text-field>

                    <v-text-field
                        min-width="300"
                        v-model="email"
                        :readonly="loading"
                        :rules="[required]"
                        class="mb-2 form"
                        label="Descrição"
                        clearable
                    ></v-text-field>
            
                    <br>

                    <v-btn
                        :loading="loading"
                        color="#daa520"
                        style="color: #fff;"
                        size="large"
                        @click="dialog = false"
                        variant="elevated"
                        block
                    >
                        <span class="mt-7">
                        Criar Task
                        </span>
                    </v-btn>
                </v-form>
            </v-card>
        </v-dialog>

        <!-- <v-main> -->
        <v-item-group class="mt-10" selected-class="bg-primary">
            <v-container>
                <v-row>
                <v-col
                    v-for="task in tasks"
                    :key="task.id"
                    cols="4"
                >
                    <Task :task="task"/>
                </v-col>
                </v-row>
            </v-container>
        </v-item-group>
        <!-- </v-main> -->
    </div>
</template>

<script setup>
import { ref, computed } from 'vue'
import Task from '../components/Task.vue'
import { useProjectStore } from '../stores/ProjectStore'

const projectStore = useProjectStore()

const project = computed(() => {
    return projectStore.project
})

const tasks = computed(() => {
  return projectStore.tasks
})

console.log('tasks: ', tasks)

let dialog = ref(false)
</script>
  
<style>
@media (min-width: 1724px) {
  .content {
    min-height: 100vh;
  }
}

.tasks {
    display: flex;
    flex-wrap: wrap;
}

</style>
  