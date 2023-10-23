<template>
  <div class="container mt-4">
    <form @submit.prevent="addContact">
      <legend>Add new Contact</legend>
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Name</label>
        <input
          type="text"
          class="form-control"
          id="text1"
          aria-describedby="Name contact"
          v-model="newContact.name"
        />
      </div>
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Email</label>
        <input
          type="email"
          class="form-control"
          id="email"
          aria-describedby="Email contact"
          v-model="newContact.email"
        />
      </div>
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Cellphone</label>
        <input
          type="text"
          class="form-control"
          id="text2"
          aria-describedby="Cellphone contact"
          v-model="newContact.cellphone"
        />
      </div>
      <button type="submit" class="btn btn-primary">Register</button>
      <RouterLink class="btn btn-primary" to="/" style="margin-left: 10px"
        >Home</RouterLink
      >
    </form>
  </div>
</template>

<script setup>
import axios from "axios";
import { reactive } from "vue";
import { useRouter } from "vue-router";

let newContact = reactive({
  name: "",
  email: "",
  cellphone: "",
});

const router = useRouter();

const addContact = () => {
  axios.post("https://localhost:7290/api/Agenda", newContact).then(() => {
    router.push("/");
  });
};
</script>
