<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'

</script>

<template>
  <v-app>
    <Header />
    <nav>
      <RouterLink to="/">Home</RouterLink>
    </nav>
    <v-main>
      <v-container>
        <h1>Vinotec</h1>
        <router-view />
      </v-container>
    </v-main>
    <Footer />
  </v-app>
</template>

<style scoped>
</style>
