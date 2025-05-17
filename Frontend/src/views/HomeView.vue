<template>
  <section>
    <div class="home">
      <h1>Bienvenido a <span>Vinotec</span></h1>
      <p>
        Descubre nuestra exclusiva selección de vinos. Tenemos todo tipos de vinos para todos los gustos. Desde tintos reserva hasta blancos afrutados, directo desde las mejores bodegas.
      </p>
      <router-link to="/vinos" class="btn">Ver vinos</router-link>
    </div>

    <div class="video">
      <video autoplay muted loop >
        <source src="@/assets/images/wine.mp4" type="video/mp4" >
      </video>
    </div>
  </section>
</template>

<script lang="ts">
export default {
  name: 'HomeView'
}
</script>

<style lang="scss" scoped>
@use '@/assets/styles.scss' as *;
</style>
