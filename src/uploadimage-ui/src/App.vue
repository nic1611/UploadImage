<template>
  <v-app>
    <v-main>
      <v-container>
        <v-row>
          <v-col>
            <RouterLink class="router-link" to="/">
              <h1 class="text-center">Upload de Imagens</h1>
            </RouterLink>
          </v-col>
        </v-row>
        <RouterView></RouterView>
      </v-container>
    </v-main>
  </v-app>
</template>

<style>
#app {
  background-color: #6200ea;
  min-height: 100vh;
}

h1 {
  color: #ffffff;
}


.router-link {
  text-decoration: none;
}
</style>

<script>
export default {
  name: "App",

  components: {},

  data: () => ({
    //
  }),
};
</script>
