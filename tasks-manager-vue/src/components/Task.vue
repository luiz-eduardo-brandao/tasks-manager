<template>
    <div>
        <v-dialog
            v-model="dialog"
            max-width="400"
            persistent
            >
            <v-card
                prepend-icon="mdi-map-marker"
                text="Let Google help apps determine location. This means sending anonymous location data to Google, even when no apps are running."
                title="Use Google's location service?"
            >
                <template v-slot:actions>
                <v-spacer></v-spacer>

                <v-btn @click="dialog = false">
                    Disagree
                </v-btn>

                <v-btn @click="dialog = false">
                    Agree
                </v-btn>
                </template>
            </v-card>
        </v-dialog>

        <v-item v-slot="{ isSelected, selectedClass, toggle }">
            <v-card 
                :class="[]"
                height="300"
                width="350"
                @click="toggle"
                class="task"
                rounded=""
            >
                <div class="descriptions">
                    <div class="task-header">
                        <v-card-title><strong>{{ task.name }}</strong></v-card-title>
                    </div>
                    <span>Tempo Gasto: 00:00:00</span>
                    <br>
                    <br>
                    <v-divider></v-divider>
                    <p class="mt-5">{{ task.description }}</p>
                </div>
    
                <div class="buttons">
                    <v-btn rounded color="success">
                        <v-icon class="">mdi-play</v-icon>
                    </v-btn>
                    <v-btn rounded color="red">
                        <v-icon class="">mdi-pause</v-icon>
                    </v-btn>
                    <!-- <v-btn color="primary" @click="dialog = true">Gravar</v-btn> -->
                </div>
            </v-card>
        </v-item>
    </div>
</template>

<script setup>
import { ref } from 'vue'

const props = defineProps(['task'])

console.log(props.task)

let task = ref(props.task)

let dialog = ref(false)
</script>

<style>
.task {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: space-between;
}

.buttons {
    display: flex;
    padding: 7px;
    margin: 10px;
    gap: 10px;
}

.descriptions {
    text-align: center;
}

.task-header {
    gap: 5px;
    display: flex;
    justify-content: space-between;
    align-items: center;
}

</style>