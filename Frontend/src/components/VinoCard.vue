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
  @mixin card-style {
    border: 1px solid #ddd;
    border-radius: 10px;
    padding: 1rem;
    box-shadow: 0 2px 6px rgba(0, 0, 0, 0.1);
    transition: transform 0.2s ease;
    background-color: white;
  
    &:hover {
      transform: scale(1.02);
    }
  }
  
  .vino-card {
    @include card-style;
    display: flex;
    flex-direction: column;
    align-items: center;
    width: 250px;
    text-align: center;
  
    .vino-img {
      width: 100%;
      height: 180px;
      object-fit: cover;
      border-radius: 6px;
      margin-bottom: 1rem;
    }
  
    .vino-info {
      h3 {
        color: #800020;
        margin-bottom: 0.5rem;
      }
      p {
        margin: 0.25rem 0;
        font-size: 0.9rem;
      }
    }
  }
  </style>
  