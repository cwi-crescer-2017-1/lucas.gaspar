document.addEventListener('DOMContentLoaded', function() {
  let btnPesquisar = document.getElementById('btnPesquisar');
  btnPesquisar.onclick = function() {
    console.log("clicou");
    let tbidpokemon = document.getElementById('tbidpokemon');
    url = "http://pokeapi.co/api/v2/pokemon/" + tbidpokemon.value + "/"
    console.log("ESSA É A URL",url);
    console.log(tbidpokemon.value);
      fetch(url)
      .then(response => response.json())
      .then(json => {
        console.log(json);
        console.log(json.sprites.front_default);
        let div = document.getElementById('detalhesPokemon');
        let img = document.createElement('img');
        img.src = json.sprites.front_default;
        div.append(img);
      })
  }
})
