<template>
    <v-container>
      <div class="vinos-page">
        <h1>Buscador de vinos</h1>
  
        <v-text-field
          v-model="searchTerm"
          label="Buscar vino"
          prepend-icon="mdi-magnify"
          class="mb-4"
          clearable
        ></v-text-field>
  
        <v-alert v-if="filteredVinos.length === 0" type="info" class="mb-4">
          No se encontraron vinos que coincidan con {{ searchTerm }}.
        </v-alert>
      </div>
  
      <section class="catalogo">
        <VinoCard
          v-for="vino in filteredVinos"
          :key="vino.id"
          :nombre="vino.nombre"
          :tipo="vino.tipo"
          :año="parseInt(vino.año.split('-')[0])"
          :graduacion="vino.graduacion"
          :precio="vino.precio"
        />
      </section>
    </v-container>
  </template>
  
  <script lang="ts">
  import { defineComponent, ref, computed, onMounted } from 'vue'
  import { useVinosStore } from '@/stores/vinos'
  import VinoCard from '@/components/VinoCard.vue'
  
  export default defineComponent({
    name: 'VinosView',
    components: { VinoCard },
    setup() {
      const vinosStore = useVinosStore()
      const searchTerm = ref('')
  
      onMounted(() => {
        vinosStore.fetchVinos()
      })
  
      const filteredVinos = computed(() =>
        vinosStore.vinos.filter((vino) =>
          vino.nombre.toLowerCase().includes(searchTerm.value.toLowerCase())
        )
      )
  
      return {
        searchTerm,
        filteredVinos
      }
    }
  })
  </script>
  