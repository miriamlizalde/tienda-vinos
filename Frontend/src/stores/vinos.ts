import { reactive } from 'vue';
import { defineStore } from 'pinia';
import type {Vino} from '@/core/vino';

export const useVinosStore = defineStore('vinos', () => {
    const vinos = reactive(new Array<Vino>());

    function fetchAll() {
        fetch('http://localhost:5292/api/Vino')
            .then(res => res.json())
            .then(data => {
                if (!data || !Array.isArray(data)) {
                    console.error('Error: La API no devuelve un array válido', data);
                    return;
                }
                vinos.splice(0, vinos.length, ...data); // ✅ Reemplaza el estado actual con nuevos datos
            })
            .catch(error => console.error('Error al obtener clientes:', error));
    }

    async function addVino(nuevoVino: { bodegaId: number, nombre: string, tipo: string, año: string, graduacion: number, precio: number, stock: number, nombreBodega?: string }) {
        try {
          const response = await fetch('http://localhost:5292/api/Vino', {
            method: 'POST',
            headers: {
              'Content-Type': 'application/json',
            },
            body: JSON.stringify(nuevoVino),
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
    
    async function deleteVino(id: number) {
        try {
            const response = await fetch(`http://localhost:5292/api/Vino/${id}`, {
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
    

    return { vinos, fetchAll, addVino, deleteVino }; // ✅ Asegúrate de incluir `addCliente` en el return
});



