<template>
  <div class="about">
    <v-row>
      <h1>Cadastre uma nova obra</h1>
    </v-row>
    <v-row class="mt-16">
      <v-form>
        <v-text-field dark label="Titulo"> </v-text-field>
        <v-file-input accept="image/*" dark label="Imagem"> </v-file-input>
      </v-form>
    </v-row>
  </div>
</template>

<script>
export default {
  name: "About",
  components: {},
};
</script>
