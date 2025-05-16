import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import VinoView from '../views/VinoView.vue'
import BodegaView from '../views/BodegaView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/vinos',
      name: 'vinos',
      component: VinoView
    },
    {
      path: '/bodegas',
      name: 'bodegas',
      component: BodegaView
    },
  ],
})

export default router
