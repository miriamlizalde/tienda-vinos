<template>
    <div class="vino-card">

      <div class="vino-info">
        <h3>{{ nombre }}</h3>
        <p><strong>Ecologica:</strong> {{ ecologica }}</p>
        <p><strong>Localizacion:</strong> {{ localizacion }}</p>
        <p><strong>Activa:</strong> {{ activa }}</p>
        
      </div>
    </div>
  </template>
  
  <script lang="ts">
  export default {
    name: 'BodegaCard',
    props: {
      nombre: { type: String, required: true },
      ecologica: { type: Boolean, required: true },
      localizacion: { type: String, required: true },
      activa: { type: Boolean, required: true },
    }
  }
  </script>
  
  <style lang="scss" scoped>
  @use '@/assets/vinoCard.scss'
  </style>
  