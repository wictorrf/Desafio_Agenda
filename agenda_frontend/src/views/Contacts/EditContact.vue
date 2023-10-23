<template>
  <div class="container mt-4">
    <form @submit.prevent="updateContact">
      <legend>Update Contact</legend>
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Name</label>
        <input
          type="text"
          class="form-control"
          id="text1"
          aria-describedby="Name contact"
          v-model="contactUpdated.name"
        />
      </div>
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Email</label>
        <input
          type="email"
          class="form-control"
          id="email"
          aria-describedby="Email contact"
          v-model="contactUpdated.email"
        />
      </div>
      <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Cellphone</label>
        <input
          type="text"
          class="form-control"
          id="text2"
          aria-describedby="Cellphone contact"
          v-model="contactUpdated.cellphone"
        />
      </div>
      <button type="submit" class="btn btn-primary">Update</button>
      <RouterLink class="btn btn-primary" to="/" style="margin-left: 10px"
        >Home</RouterLink
      >
    </form>
  </div>
</template>

<script setup>
import axios from "axios";
import { onMounted, reactive } from "vue";
import { useRoute, useRouter } from "vue-router";

let contactUpdated = reactive({
  id: 0,
  name: "",
  email: "",
  cellphone: "",
});

const route = useRoute();
const router = useRouter();

onMounted(() => {
  axios
    .get(`https://localhost:7290/api/Agenda/${route.params.id}`)
    .then((response) => {
      contactUpdated.name = response.data.name;
      contactUpdated.email = response.data.email;
      contactUpdated.cellphone = response.data.cellphone;
      contactUpdated.id = response.data.id;
    });
});

const updateContact = () => {
  axios
    .put(`https://localhost:7290/api/Agenda/${route.params.id}`, contactUpdated)
    .then(() => {
      router.push("/");
    });
};
</script>
