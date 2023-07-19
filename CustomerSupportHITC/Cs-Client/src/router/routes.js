const routes = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [
      { path: 'index',name: 'index', component: () => import('pages/IndexPage.vue') },
      { path: 'detail',name: 'detail', component: () => import('pages/Detail.vue') },
      { path: 'detailedit/:id',name: 'detailedit', component: () => import('pages/DetailEdit.vue') }
    ]
  },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/ErrorNotFound.vue')
  }
]

export default routes
