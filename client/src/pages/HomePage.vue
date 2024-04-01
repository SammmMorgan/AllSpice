<template>
  <div class="container-fluid">
    <section class="row">
      <div class="col-12 d-flex background-img">
        <p class="display-5 m-auto text-white">Cherish Your Beans</p>
      </div>
    </section>
  </div>
  <div class="container">
    <section class="row">
      <RecipeCard />
    </section>
  </div>
</template>

<script>
export default {
  setup() {
    return {

    }
  }
}
</script>

<style scoped lang="scss">
.background-img {
  background-image: url(https://images.unsplash.com/photo-1564149504298-00c351fd7f16?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D);
  background-position: center;
  position: absolute;
  top: 0px;
  bottom: 300px;
}
</style>
