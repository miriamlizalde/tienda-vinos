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
          @keyup.enter="buscarVinos"
          class="flex-grow-1"
        ></v-text-field>

        <v-btn icon color="primary" @click="buscarVinos">
          <v-icon>mdi-magnify</v-icon>
        </v-btn>
      </div>

      <v-alert v-if="filteredVinos.length === 0" type="info" class="mb-4">
        No se encontraron vinos que coincidan con {{ searchTerm }}.
      </v-alert>
    </div>

    <section class="catalogo d-flex flex-wrap gap-4">
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
    const searchInput = ref('')
    const searchTerm = ref('')

    onMounted(() => {
      vinosStore.fetchVinos()
    })

    const buscarVinos = () => {
      searchTerm.value = searchInput.value.trim()
    }

    const filteredVinos = computed(() =>
      vinosStore.vinos.filter((vino) =>
        vino.nombre.toLowerCase().includes(searchTerm.value.toLowerCase())
      )
    )

    return {
      searchInput,
      searchTerm,
      filteredVinos,
      buscarVinos,
    }
  },
})
</script>

<style scoped>
.search-bar {
  gap: 1rem;
}
.catalogo {
  display: flex;
  flex-wrap: wrap;
}
</style>
