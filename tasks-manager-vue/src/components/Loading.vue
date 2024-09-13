<template>
    <div class="text-center">
        <v-overlay
        :model-value="loading.overlay"
        class="align-center justify-center"
        >
        <v-progress-circular
            color="primary"
            size="64"
            indeterminate
        ></v-progress-circular>
        </v-overlay>
  </div>
</template>

<script setup>
import { useLoadingStore } from '@/stores/LoadingStore';

const loading = useLoadingStore()

</script>
