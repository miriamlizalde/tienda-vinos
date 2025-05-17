<template>
  <v-container>
    <div class="vinos-page">
      <h1>Buscador de vinos</h1>

      <div class="search-bar d-flex align-center mb-4">
        <v-text-field
          v-model="searchInput"
          label="Buscar vino"
          prepend-icon="mdi-magnify"
          clearable
          @keyup.enter="buscarBodega"
          class="flex-grow-1"
        ></v-text-field>

        <v-btn icon color="primary" @click="buscarBodega">
          <v-icon>mdi-magnify</v-icon>
        </v-btn>
      </div>

      <v-alert v-if="filteredBodega.length === 0" type="info" class="mb-4">
        No se encontraron vinos que coincidan con {{ searchTerm }}.
      </v-alert>
    </div>

    <section class="catalogo d-flex flex-wrap gap-4">
      <BodegaCard
      v-for="bodega in filteredBodega"
      :key="bodega.id"
      :nombre="bodega.nombre"
      :ecologica="bodega.ecologica"
      :localizacion="bodega.localizacion"
      :activa="bodega.activa"
/>
    </section>
  </v-container>
</template>
  
  <script lang="ts">
    import { defineComponent, ref, computed, onMounted } from 'vue'
    import { useBodegaStore } from '@/stores/bodega'
    import BodegaCard from '@/components/BodegaCard.vue'
    

    export default defineComponent({
      name: 'BodegaView',
      components: { BodegaCard },
      setup() {
        const bodegaStore = useBodegaStore()
        const searchInput = ref('')
        const searchTerm = ref('')

        onMounted(() => {
          bodegaStore.fetchAll()
        })

        const buscarBodega = () => {
          searchTerm.value = searchInput.value.trim()
        }

        const filteredBodega = computed(() =>
          bodegaStore.bodegas.filter((bodega) =>
            bodega.nombre.toLowerCase().includes(searchTerm.value.toLowerCase())
          )
        )

        return {
          searchInput,
          searchTerm,
          filteredBodega,
          buscarBodega,
        }
      },
    })
</script>
  
  <style scoped>
  </style>
  