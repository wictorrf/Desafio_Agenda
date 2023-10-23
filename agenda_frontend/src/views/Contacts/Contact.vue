<template>
  <div class="container">
    <div class="col col-md-3 m-2">
      <RouterLink class="btn btn-primary" to="/add">New Contact</RouterLink>
    </div>
    <div class="row row-cols-1 row-cols-md-3 g-4">
      <div class="col" v-for="item in contactList" :key="item.id">
        <div class="card">
          <div class="card-body">
            <h5 class="card-title">Contact</h5>
            <p class="card-text">
              {{ item.name }}
            </p>
            <p class="card-text">
              {{ item.email }}
            </p>
            <p class="card-text">
              {{ item.cellphone }}
            </p>
            <div class="container" id="botoes">
              <RouterLink class="btn btn-primary" :to="`/edit/${item.id}`"
                >Edit</RouterLink
              >
              <button
                type="button"
                @click="($event) => openDeleteModel(item.id)"
                class="btn btn-danger"
                style="margin-left: 10px"
              >
                Delete
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <ConfirmDeletePopup
      @confirm-delete-click="confirmDelete"
    ></ConfirmDeletePopup>
  </div>
</template>

<script setup>
import { onMounted, ref } from "vue";
import axios from "axios";
import ConfirmDeletePopup from "../../components/ConfirmDeletePopup.vue";

const contactList = ref([]);
const deleteItemId = ref(0);
let deleteModalInstance;

onMounted(() => {
  deleteModalInstance = new window.bootstrap.Modal(
    document.getElementById("deletePopup")
  );
  axios.get("https://localhost:7290/api/Agenda").then((response) => {
    contactList.value = response.data;
  });
});

const openDeleteModel = (id) => {
  deleteItemId.value = id;
  deleteModalInstance.show();
};

const confirmDelete = () => {
  axios
    .delete(`https://localhost:7290/api/Agenda/${deleteItemId.value}`)
    .then(() => {
      contactList.value = contactList.value.filter(
        (_) => _.id !== deleteItemId.value
      );
      deleteModalInstance.hide();
    });
};
</script>

<style scoped>
</style>
