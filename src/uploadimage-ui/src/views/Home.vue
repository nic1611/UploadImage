<template>
  <div class="home">
    <v-row>
      <v-col min-width="300" class="text-center">
        <h2>Lista de Obras de Arte</h2>
      </v-col>
      <v-col min-width="300" class="text-center">
        <RouterLink class="router-link" to="/About">
          <v-btn color="#0a00b6" rounded dark>Nova Obra</v-btn>
        </RouterLink>
      </v-col>
    </v-row>
    <v-row class="mt-16" justify="space-around">
      <v-card v-for="n in 10" :key="n" color="#9d46ff" dark class="p-10 mt-8">
        <v-row>
          <v-col class="px-6">
            <v-img
              height="200"
              width="200"
              src="https://cdn.vuetifyjs.com/images/cards/store.jpg"
            ></v-img>
          </v-col>
          <v-col justify="space-around">
            <v-card-subtitle>Descricao</v-card-subtitle>
            <v-card-actions>
              <v-btn rounded outlined small dark color="#0a00b6">Apagar</v-btn>
            </v-card-actions>
          </v-col>
        </v-row>
      </v-card>
    </v-row>
  </div>
</template>

<style scoped>
.col-des {
  height: 200px;
}
</style>

<script>
export default {
  name: "Home",
  components: {},
};
</script>
