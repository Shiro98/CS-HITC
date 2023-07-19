<template>
  <q-layout view="lHh Lpr lFf">
    <q-header>
      <q-toolbar class="bg-primary text-white rounded-borders">
        <img
            src="https://htc-itc.com.vn/wp-content/themes/htc/images/logo-color.png?time=1688391317"
            style="width: 200px; height: 64px"
          > 
        <q-space />
        <div class="q-gutter-md">
          <q-btn round icon="help_outline" color="primary" class="q-mr-xs" />
          <q-btn round icon="notifications" class="q-mr-xs" />
          <q-btn round icon="apps" class="q-mr-xs" />
          <q-btn round class="q-mr-xs" color="primary" icon="person" />
        </div>
        <!-- <q-input dark dense standout v-model="text" input-class="text-left" label="Nhập từ khóa" class="q-ml-md">
          <template v-slot:append>
            <q-icon v-if="text === ''" name="search" />
            <q-icon v-else name="clear" class="cursor-pointer" @click="text = ''" />
          </template>
          <template v-slot:after>
            <q-btn color="primary" label="Lọc dữ liệu" />
        </template>
        </q-input> -->

      </q-toolbar>
    </q-header>

    <!-- <q-drawer
      v-model="leftDrawerOpen"
      show-if-above
      bordered
    >
      <q-list>
        <q-item-label
          header
        >
          Essential Links
        </q-item-label>

        <EssentialLink
          v-for="link in essentialLinks"
          :key="link.title"
          v-bind="link"
        />
      </q-list>
    </q-drawer> -->

    <q-page-container>
      <router-view />
    </q-page-container>
  </q-layout>
</template>

<script>
// import { defineComponent, ref } from 'vue'
// import EssentialLink from 'components/EssentialLink.vue'

// const linksList = [
//   {
//     title: 'Docs',
//     caption: 'quasar.dev',
//     icon: 'school',
//     link: 'https://quasar.dev'
//   },
//   {
//     title: 'Github',
//     caption: 'github.com/quasarframework',
//     icon: 'code',
//     link: 'https://github.com/quasarframework'
//   },
//   {
//     title: 'Discord Chat Channel',
//     caption: 'chat.quasar.dev',
//     icon: 'chat',
//     link: 'https://chat.quasar.dev'
//   },
//   {
//     title: 'Forum',
//     caption: 'forum.quasar.dev',
//     icon: 'record_voice_over',
//     link: 'https://forum.quasar.dev'
//   },
//   {
//     title: 'Twitter',
//     caption: '@quasarframework',
//     icon: 'rss_feed',
//     link: 'https://twitter.quasar.dev'
//   },
//   {
//     title: 'Facebook',
//     caption: '@QuasarFramework',
//     icon: 'public',
//     link: 'https://facebook.quasar.dev'
//   },
//   {
//     title: 'Quasar Awesome',
//     caption: 'Community Quasar projects',
//     icon: 'favorite',
//     link: 'https://awesome.quasar.dev'
//   }
// ]

// export default defineComponent({
//   name: 'MainLayout',

//   components: {
//     EssentialLink
//   },

//   setup () {
//     const leftDrawerOpen = ref(false)

//     return {
//       essentialLinks: linksList,
//       leftDrawerOpen,
//       toggleLeftDrawer () {
//         leftDrawerOpen.value = !leftDrawerOpen.value
//       }
//     }
//   }
// })
</script>
