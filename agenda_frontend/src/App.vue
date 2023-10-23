<script setup>
import { RouterLink, RouterView } from "vue-router";
</script>

<template>
  <nav class="navbar bg-secondary" data-bs-theme="dark">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">Agenda Contatos</a>
    </div>
  </nav>
  <div class="container"></div>
  <RouterView />
</template>

<style scoped>
</style>
