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
        <v-card color="#9d46ff" dark>
          <v-row>
            <v-col>
              <v-card-title>Titulo</v-card-title>
            </v-col>
            <v-col>
              <v-card-subtitle>Descricao</v-card-subtitle>
              <v-btn rounded outlined small dark color="#0a00b6">Apagar</v-btn>
            </v-col>
          </v-row>
        </v-card>
        <v-card color="#9d46ff" dark>
          <v-row>
            <v-col>
              <v-card-title>Titulo</v-card-title>
            </v-col>
            <v-col>
              <v-card-subtitle>Descricao</v-card-subtitle>
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

</style>

<script>
export default {
  name: "Home",
  components: {},
};
</script>
