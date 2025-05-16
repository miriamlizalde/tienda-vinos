<template>
    <header class="header">
      <nav class="navbar">
        <router-link to="/" class="logo">VinoSelect</router-link>
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
  .header {
    background-color: #800020;
    padding: 1rem 2rem;
    color: white;
  
    .navbar {
      display: flex;
      justify-content: space-between;
      align-items: center;
  
      .logo {
        font-size: 1.5rem;
        font-weight: bold;
        color: white;
        text-decoration: none;
      }
  
      .nav-links {
        display: flex;
        gap: 1.5rem;
        list-style: none;
  
        a {
          color: white;
          text-decoration: none;
          font-weight: 500;
  
          &:hover {
            text-decoration: underline;
          }
        }
      }
    }
  }
  </style>
  