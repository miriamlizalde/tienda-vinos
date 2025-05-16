<template>
  <section>
    <div class="home">
      <h1>Bienvenido a <span>Vinotec</span></h1>
      <p>
        Descubre nuestra exclusiva selección de vinos. Tenemos todo tipos de vinos para todos los gustos. Desde tintos reserva hasta blancos afrutados, directo desde las mejores bodegas.
      </p>
      <router-link to="/vinos" class="btn">Ver vinos</router-link>
    </div>

    <div class="copavino">
      <img src="@/assets/images/copavino.jpg" alt="Copa de vino" />
    </div>
  </section>
</template>

<script lang="ts">
export default {
  name: 'HomeView'
}
</script>

<style lang="scss" scoped>
.home {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 3rem;
  gap: 2rem;
  flex-wrap: wrap;

  .intro {
    flex: 1;
    min-width: 300px;

    h1 {
      font-size: 2.5rem;
      color: #800020;

      span {
        color: #4b0000;
      }
    }

    p {
      margin: 1rem 0 2rem;
      font-size: 1.2rem;
      color: #444;
      line-height: 1.5;
    }

    .btn {
      background-color: #800020;
      color: white;
      padding: 0.75rem 1.5rem;
      text-decoration: none;
      border-radius: 5px;
      transition: background-color 0.3s;

      &:hover {
        background-color: #a52a2a;
      }
    }
  }

  .hero-image {
    flex: 1;
    min-width: 300px;
    text-align: center;

    img {
      max-width: 100%;
      border-radius: 10px;
      box-shadow: 0 4px 12px rgba(0, 0, 0, 0.15);
    }
  }
}
</style>
