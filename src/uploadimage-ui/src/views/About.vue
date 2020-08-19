<template>
  <div class="about">
    <v-row>
      <v-col>
        <h2>Cadastre uma nova obra</h2>
      </v-col>
    </v-row>
    <v-row class="mt-16">
      <v-col>
        <v-form>
          <v-text-field v-model="obj.Nome" dark label="Nome"></v-text-field>
          <v-file-input v-model="obj.Imagem" accept="image/*" dark label="Imagem">
          </v-file-input>
          <v-btn class="mt-6" rounded dark color="#0a00b6" v-on:click="this.log"
            >Enviar</v-btn
          >
        </v-form>
      </v-col>
    </v-row>
  </div>
</template>

<script>
export default {
  name: "About",
  components: {},
  data() {
    return {
      obj: {
        Nome: null,
        Imagem: null,
      },
    };
  },
  methods: {
    log() {
      console.log(this.obj.Nome, this.obj.Imagem);
      this.enviarParaApi();
    },
    enviarParaApi() {
      fetch("https://localhost:5001/novo/", {
        method: "post",
        body: this.obj,
      }).then(function(response) {
        return response.json();
      });
    },
  },
};
</script>
