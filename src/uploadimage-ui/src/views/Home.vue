<template>
  <div class="home">
    <v-row>
      <v-col min-width="300" class="text-center">
        <h2>Lista de Imagens</h2>
      </v-col>
      <v-col min-width="300" class="text-center">
        <RouterLink class="router-link" to="/About">
          <v-btn color="#0a00b6" rounded dark>Nova Imagem</v-btn>
        </RouterLink>
      </v-col>
    </v-row>
    <v-row class="mt-16" justify="space-around">
      <v-card
        v-for="n in Images"
        :key="n.Id"
        color="#9d46ff"
        dark
        class="p-10 mt-8"
      >
        <v-row>
          <v-col class="px-6">
            <v-img height="200" width="200" :src="n.imagem"></v-img>
          </v-col>
          <v-col justify="space-around">
            <v-card-subtitle>{{ n.nome }}</v-card-subtitle>
            <v-card-actions>
              <v-btn
                rounded
                outlined
                small
                dark
                color="#0a00b6"
                v-on:click="deleteImage(n.id)"
                >Apagar</v-btn
              >
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
  data() {
    return {
      Images: [],
      ImageTitulo: String,
    };
  },
  methods: {
    getImages() {
      fetch("https://localhost:5001/", {
        method: "get",
      })
        .then((e) => e.json())
        .then((k) => {
          console.log(k);
          this.Images = k;
        });
    },
    deleteImage(id) {
      fetch(`https://localhost:5001/remover/${id}`, { method: "delete" }).then(
        () => {
          this.getImages();
        }
      );
    },
  },
  beforeMount() {
    this.getImages();
  },
};
</script>
