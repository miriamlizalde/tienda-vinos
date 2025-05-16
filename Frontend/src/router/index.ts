import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

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
      component: () => import('../views/VinoView.vue'),
    },
    {
      path: '/bodegas',
      name: 'bodegas',
      component: () => import('../views/BodegaView.vue'),
    },
  ],
})

export default router
