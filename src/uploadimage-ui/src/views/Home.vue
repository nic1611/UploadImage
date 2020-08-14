<template>
  <div class="home">
    <v-container>
      <v-row>
        <v-col>
          <h1 class="text-center">Upload de Imagens</h1>
        </v-col>
      </v-row>
      <v-layout justify-space-between>
        <h1>Lista de Obras de Arte</h1>
        <v-btn color="#0a00b6" rounded dark>Nova Obra</v-btn>
      </v-layout>
      <v-row class="mt-16" justify="space-around">
        <v-card v-for="n in 10" :key="n" color="#9d46ff" dark class="p-10">
          <v-row>
            <v-col  class="px-6">
              <v-img 
                height="200"
                width="200"
                src="https://cdn.vuetifyjs.com/images/cards/store.jpg"
              ></v-img>
            </v-col>
            <v-col justify="space-around">
              <v-card-subtitle>Descricao</v-card-subtitle>
              <v-card-actions>
                <v-btn rounded outlined small dark color="#0a00b6"
                  >Apagar</v-btn
                >
              </v-card-actions>
            </v-col>
          </v-row>
        </v-card>
      </v-row>
    </v-container>
  </div>
</template>

<style scoped>
.home {
  background-color: #6200ea;
  height: 100vh;
}

h1 {
  color: #ffffff;
}
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
