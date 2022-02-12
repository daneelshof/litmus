<template>
  <div>
    <div>
      <nav class="bg-gray-800">
        <div class="max-w-7xl mx-auto px-4 sm:px-6 lg:px-8">
          <div class="flex items-center justify-between h-16">
            <div class="flex items-center">
              <div class="flex-shrink-0">
                <img src="~/assets/litmus.svg" class="h-12" />
              </div>
              <div class="hidden md:block">
                <div class="ml-10 flex items-baseline">
                  <NuxtLink
                    v-for="link in menuLinks"
                    :key="link.href"
                    :to="link.href"
                    class="ml-4 px-3 py-2 rounded-md text-sm font-medium text-white focus:outline-none focus:text-white focus:bg-gray-700 hover:bg-gray-500"
                  >{{ link.name }}</NuxtLink>
                </div>
              </div>
            </div>
            <div class="hidden md:block">
              <div class="ml-4 flex items-center md:ml-6">
                <button
                  class="p-1 border-2 border-transparent text-gray-400 rounded-full hover:text-white focus:outline-none focus:text-white focus:bg-gray-700 hover:bg-gray-500"
                  aria-label="Notifications"
                >
                  <bell-icon class="h-6 w-6 text-gray-100"></bell-icon>
                </button>

                <!-- User Menu -->
                <div class="ml-3 relative">
                  <div>
                    <button
                      @click="toggle"
                      class="p-1 border-2 border-transparent text-gray-400 rounded-full hover:text-white focus:outline-none focus:text-white focus:bg-gray-700 hover:bg-gray-500"
                      id="user-menu"
                      aria-label="User menu"
                      aria-haspopup="true"
                    >
                      <user-icon class="h-6 w-6 text-gray-100"></user-icon>
                    </button>
                  </div>
                  <transition
                    enter-active-class="transition ease-out duration-100"
                    enter-class="transform opacity-0 scale-95"
                    enter-to-class="transform opacity-100 scale-100"
                    leave-active-class="transition ease-in duration-75"
                    leave-class="transform opacity-100 scale-100"
                    leave-to-class="transform opacity-0 scale-95"
                  >
                    <div
                      v-show="isOpen"
                      class="origin-top-right absolute right-0 mt-2 w-48 rounded-md shadow-lg"
                    >
                      <div
                        class="py-1 rounded-md bg-white shadow-xs"
                        role="menu"
                        aria-orientation="vertical"
                        aria-labelledby="user-menu"
                      >
                        <NuxtLink
                          v-for="link in userLinks"
                          :key="link.href"
                          :to="link.href"
                          class="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                          role="menuitem"
                        >{{ link.name }}</NuxtLink>
                      </div>
                    </div>
                  </transition>
                </div>
              </div>
            </div>
            <div class="-mr-2 flex md:hidden">
              <!-- Hamburger Menu -->
              <button
                @click="toggle"
                class="inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-white hover:bg-gray-700 focus:outline-none focus:bg-gray-700 focus:text-white hover:bg-gray-500"
              >
                <menu-icon :class="[isOpen ? 'hidden' : 'block', 'h-6 w-6']"></menu-icon>
                <x-icon :class="[isOpen ? 'block' : 'hidden', 'h-6 w-6']"></x-icon>
              </button>
            </div>
          </div>
        </div>
        <div :class="[isOpen ? '' : 'hidden', 'md:hidden']">
          <div class="px-2 pt-2 pb-3 sm:px-3">
            <NuxtLink
              v-for="link in menuLinks"
              :key="link.href"
              :to="link.href"
              class="mt-1 block px-3 py-2 rounded-md text-base font-medium text-gray-300 hover:text-white hover:bg-gray-700 focus:outline-none focus:text-white focus:bg-gray-700"
            >{{ link.name }}</NuxtLink>
          </div>
          <div class="pt-4 pb-3 border-t border-gray-700">
            <div class="flex items-center px-5">
              <div class="flex-shrink-0 rounded-full bg-gray-500">
                <user-icon class="h-8 w-8 rounded-full text-gray-100"></user-icon>
              </div>
              <div class="ml-3">
                <div class="text-base font-medium leading-none text-white">Authenticated User</div>
                <div class="mt-1 text-sm font-medium leading-none text-gray-400">a.user</div>
              </div>
            </div>
            <div class="mt-3 px-2">
              <NuxtLink
                v-for="link in userLinks"
                :key="link.href"
                :to="link.href"
                class="mt-1 block px-3 py-2 rounded-md text-base font-medium text-gray-400 hover:text-white hover:bg-gray-700 focus:outline-none focus:text-white focus:bg-gray-700"
              >{{ link.name }}</NuxtLink>
            </div>
          </div>
        </div>
      </nav>

      <!--<header class="bg-white shadow">
        <div class="max-w-7xl mx-auto py-6 px-4 sm:px-6 lg:px-8">
          <h1 class="text-3xl font-bold leading-tight text-gray-900">My Testing</h1>
        </div>
      </header>-->
    </div>
  </div>
</template>

<script>
import { BellIcon, MenuIcon, UserIcon, XIcon } from 'vue-feather-icons'

export default {
  data () {
    return {
      isOpen: false,
      menuLinks: [
        { name: 'My Testing', href: '/my-testing' },
        { name: 'Plans', href: '/plans' },
        { name: 'Results', href: '/results' },
        { name: 'Environments', href: '/environments' },
        { name: 'Administration', href: '/administration' }
      ],
      userLinks: [
        { name: 'My Profile', href: '/user/profile' },
        { name: 'Settings', href: '/user/settings' },
        { name: 'Log out', href: '/user/log-out' },
      ]
    }
  },
  components: {
    BellIcon,
    MenuIcon,
    UserIcon,
    XIcon
  },
  methods: {
    toggle () {
      this.isOpen = !this.isOpen
    }
  }
}
</script>
