<template>
    <header class="header">
      <nav class="navbar">
        <router-link to="/" class="logo">Vinotec</router-link>
        <ul class="nav-links">
          <li><router-link to="/">Inicio</router-link></li>
          <li><router-link to="/vinos">Vinos</router-link></li>
          <li><router-link to="/bodegas">Bodegas</router-link></li>
        </ul>
      </nav>
    </header>
  </template>
  
  <script lang="ts">
  export default {
    name: 'Header'
  }
  </script>
  
  <style lang="scss" scoped>
  @use '@/assets/header.scss' as *;
  </style>
  