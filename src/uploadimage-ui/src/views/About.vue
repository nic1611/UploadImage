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
          <v-file-input
            @change="getBase64"
            accept="image/*"
            dark
            label="Imagem"
          >
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
    getBase64() {
      var file = document.querySelector("input[type=file]").files[0];
      var reader = new FileReader();

      reader.onload = (e) => {
        this.obj.Imagem = e.target.result;
      };
      reader.readAsDataURL(file);
    },
    log() {
      this.enviarParaApi();
    },
    enviarParaApi() {
      fetch("https://localhost:5001/novo/", {
        method: "post",
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
        body: JSON.stringify(this.obj),
      }).then(function(e) {
        if (e.status == 200) {
          alert("Imagem cadastrada com sucesso");
        } else {
          alert("Problema ao cadastrar a imagem");
        }
      });
    },
  },
};
</script>
