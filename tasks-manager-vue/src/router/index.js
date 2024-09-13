import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import { useAuthStore } from '@/stores/AuthStore.js'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/login',
      name: 'Login',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/Account/Login.vue')
    },
    {
      path: '/createProject',
      name: 'createProject',
      component: () => import('../views/CreateProject.vue'),
      meta: {
        authorize: true
      }
    },
    {
      path: '/project',
      name: 'project',
      component: () => import('../views/ProjectView.vue'),
      meta: {
        authorize: true
      }
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (to.meta?.authorize) {
    const userAuth = useAuthStore()
  
    if (userAuth.userAuthenticated){
      // const isTokenValid = userAuth.checkToken();
      const isTokenValid = true;
  
      if (isTokenValid)
        next();
        return
    } 
    
    next({ name: 'Login'})
    return
  }

  next()
})

export default router
