<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import Header from '@/components/Header.vue'
import Footer from '@/components/Footer.vue'

</script>

<template>
  <v-app>
    <Header />
    <v-main>
      <v-container>
        <h1>Vinotec</h1>
        <router-view />
      </v-container>
    </v-main>
    <Footer />
  </v-app>
</template>

<style lang="scss" scoped>
@use './assets/styles.scss' as *;
</style>
