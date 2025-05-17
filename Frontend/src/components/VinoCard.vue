<template>
    <div class="vino-card">
        <img v-if="imagen" :src="imagen" alt="imagen-vino" class="vino-img" />

      <div class="vino-info">
        <h3>{{ nombre }}</h3>
        <p><strong>Tipo:</strong> {{ tipo }}</p>
        <p><strong>Año:</strong> {{ año }}</p>
        <p><strong>Graduación:</strong> {{ graduacion }}%</p>
        <p><strong>Precio:</strong> {{ precio }} €</p>
      </div>
    </div>
  </template>
  
  <script lang="ts">
  export default {
    name: 'VinoCard',
    props: {
      nombre: { type: String, required: true },
      tipo: { type: String, required: true },
      año: { type: Number, required: true },
      graduacion: { type: Number, required: true },
      precio: { type: Number, required: true },
      imagen: { type: String, required: false }
    }
  }
  </script>
  
  <style lang="scss" scoped>
  @use '@/assets/vinoCard.scss'
  </style>
  