import { defineStore } from 'pinia'
import axios from 'axios'
import { ref } from 'vue'

export interface Bodega {
    id: number
    nombre: string
    ecologica: boolean
    localizacion: string
    activa: boolean
  }
  
  export interface Vino {
    id: number
    bodegaId: number
    nombre: string
    tipo: string
    año: string 
    graduacion: number
    precio: number
    stock: number
    nombreBodega?: string
  }


export const useVinosStore = defineStore('vinos', () => {
  const vinos = ref<Vino[]>([])
  const loading = ref(false)
  const error = ref<string | null>(null)

  const fetchVinos = async () => {
    loading.value = true
    try {
      const response = await axios.get('https://localhost:7150/api/vino')
      vinos.value = response.data
    } catch (err) {
      error.value = 'No se pudieron cargar los vinos.'
      console.error(err)
    } finally {
      loading.value = false
    }
  }

  const addVino = async (nuevoVino: Partial<Vino>) => {
    try {
      const response = await axios.post('https://localhost:7150/api/vino', nuevoVino)
      vinos.value.push(response.data)
    } catch (err) {
      error.value = 'Error al añadir el vino.'
      console.error(err)
    }
  }

  const removeVino = async (id: number) => {
    try {
      await axios.delete(`https://localhost:7150/api/vino/${id}`)
      vinos.value = vinos.value.filter(v => v.id !== id)
    } catch (err) {
      error.value = 'Error al eliminar el vino.'
      console.error(err)
    }
  }

  return {
    vinos,
    loading,
    error,
    fetchVinos,
    addVino,
    removeVino
  }
})
