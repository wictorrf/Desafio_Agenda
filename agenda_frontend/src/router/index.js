import { createRouter, createWebHistory } from 'vue-router'
import Contact from '../views/Contacts/Contact.vue'
import AddContact from '../views/Contacts/AddContact.vue'
import EditContact from '../views/Contacts/EditContact.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: Contact
    },
    {
      path: '/add',
      name: 'add-contact',
      component: AddContact
    },
    {
      path: '/edit/:id',
      name: 'edit-contact',
      component: EditContact
    }
  ]
})

export default router
