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