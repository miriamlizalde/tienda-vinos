<template>
    <div class="bodegas">
      <h1>NUESTRAS BODEGAS</h1>
  
      <div v-if="loading">Cargando bodegas...</div>
      <div v-else-if="error">{{ error }}</div>
      <div v-else>
        <ul>
          <li v-for="bodega in bodegasIds" :key="bodega.id">
            <h2>{{ bodega.nombre }}</h2>
            <p>Ubicación: {{ bodega.localizacion }}</p>
            <p v-if="bodega.ecologica">Bodega ecológica</p>
            <p v-if="!bodega.activa">Inactiva</p>
          </li>
        </ul>
      </div>
    </div>
  </template>
  
  <script setup lang="ts">
  import { onMounted, computed } from 'vue'
  import { useVinosStore } from '@/stores/vinos'
  
  const vinosStore = useVinosStore()
  
  onMounted(() => {
    if (vinosStore.vinos.length === 0) {
      vinosStore.fetchVinos()
    }
  })
  
  const bodegasIds = computed(() => {
    const mapa = new Map()
    for (const vino of vinosStore.vinos) {
      if (vino.nombreBodega) {
        mapa.set(vino.bodegaId, {
          id: vino.bodegaId,
          nombre: vino.nombreBodega,
          localizacion: 'Desconocida',
          ecologica: false,
          activa: true,
        })
      }
    }
    return Array.from(mapa.values())
  })
  
  const loading = computed(() => vinosStore.loading)
  const error = computed(() => vinosStore.error)
  </script>
  
  <style scoped>
  </style>
  