import { reactive } from 'vue';
import { defineStore } from 'pinia';
import type {Bodega} from '@/core/bodega';

export const useBodegaStore = defineStore('bodegas', () => {
    const bodegas = reactive(new Array<Bodega>());

    function fetchAll() {
        fetch('http://localhost:5292/api/Bodega')
            .then(res => res.json())
            .then(data => {
                if (!data || !Array.isArray(data)) {
                    console.error('Error: La API no devuelve un array válido', data);
                    return;
                }
                bodegas.splice(0, bodegas.length, ...data); // ✅ Reemplaza el estado actual con nuevos datos
            })
            .catch(error => console.error('Error al obtener clientes:', error));
    }

    async function addBodega(nuevoBodega: { nombre: string, ecologica: boolean, localizacion: string, activa: boolean }) {
        try {
          const response = await fetch('http://localhost:5292/api/Bodega', {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(nuevoBodega),
          });

          if (!response.ok) {
            throw new Error('Error al añadir el cliente');
          }

          await response.json();
          fetchAll();  // ✅ Ahora se recarga la lista después de añadir un cliente nuevo
        } catch (error) {
          console.error('Error al añadir cliente:', error);
        }
    }
    
    async function deleteBodega(id: number) {
        try {
            const response = await fetch(`http://localhost:5292/api/Bodega/${id}`, {
                method: 'DELETE',
            });
    
            if (!response.ok) {
                throw new Error('Error al eliminar el cliente');
            }
    
            fetchAll(); // ✅ Recarga la lista de clientes después de eliminar
        } catch (error) {
            console.error('Error al eliminar cliente:', error);
        }
    }
    

    return { bodegas, fetchAll, addBodega, deleteBodega }; // ✅ Asegúrate de incluir `addCliente` en el return
});



