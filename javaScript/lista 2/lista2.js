// Exercicio 1
function seriesInvalidadas(series) {
    let resp = [];
    let anoAtual = new Date();
    anoAtual = anoAtual.getFullYear();
    for (let i = 0; i < series.length; i++) {
        if (series[i].anoEstreia > anoAtual || Object.values(series[i]).some(v => v == null || typeof v === 'undefined')) {
            resp.push(series[i].titulo);
        }
    }
    return resp.toString();
}

console.log(seriesInvalidadas(series));

// Exercicio 2
function filtrarSeriesAno(series, ano) {
    let resp = [];
    for (let i = 0; i < series.length; i++) {
      if (series[i].anoEstreia >= ano){
          resp.push(series[i]);
      }
    }
    return resp;
}

console.log(filtrarSeriesAno(series, 2016));
// Exercicio 3

function mediaDeEpisodios(series) {
    let calculo = 0, cont=0;
    for (let i = 0; i < series.length; i++){
        calculo += series[i].numeroEpisodios;
        cont ++;
    }
    return calculo/cont;
}

console.log(mediaDeEpisodios(series));

//Exericio 4

function procurarPorNome(series, nome) {
    let elenco = [];
    for (let i = 0; i < series.length; i++) {
      elenco = series[i].elenco;
          for (let j = 0; j < elenco.length; j++) {
            if (elenco[j]===nome) {
              return true;
            }
          }
    }
    return false;
}

console.log(procurarPorNome(series, "Lucas Gaspar"));

var serieteste = {anoEstreia: 2016, diretor:['Lucas','Gaspar'], distribuidora: 'NetFlix', elenco: ['Dicaprio', 'Portmann'], genero:['comédia', 'aventura'], numeroEpisodios: 20, titulo: 'A volta dos que não foram'};

// Exercicio 5
function mascadaSerie(serieteste){
    let atores, diretores;
    diretores = serieteste.diretor.length;
    diretores = 100000*diretores;
    atores = serieteste.elenco.length;
    atores = 40000*atores;
    return `O elenco dessa série ganha R$ ${atores+diretores}`
}

console.log(mascadaSerie(serieteste));
console.log(mascadaSerie(series[0]));

// Exercício 6
function queroGenero(genero) {
    let resp = [];
    for (let i = 0; i < series.length; i++) {
      for (let j = 0; j < series[i].genero.length; j++) {
        if (series[i].genero[j] === genero) {
            resp.push(series[i]);
        }
      }
    }
    return resp;
}

console.log(queroGenero("Caos"));

function queroTitulo(titulo) {
    let resp = [];
    for (let i = 0; i < series.length; i++) {
        if (series[i].titulo.includes(titulo)) {
            resp.push(series[i].titulo);
        }
    }
    return resp;
}

console.log(queroTitulo("The"));

// Exericio 7 Corrigido


function creditosIlluminatis(serie) {
  let criterioDeOrdenacao = (s1, s2) => {
    return s1.pegarUltimoNome().localeCompare(s2.pegarUltimoNome())
  }
  let elencoOrdenado = serie.elenco.sort(criterioDeOrdenacao);
  let diretoresOrdenados = serie.diretor.sort(criterioDeOrdenacao);

  console.log(serie.titulo);
  console.log("Diretores");
  console.log(diretoresOrdenados);
  console.log("Elenco");
  console.log(elencoOrdenado);
}

creditosIlluminatis(series[0]);

// Exercicio 8

function descobrirSerieComTodosAbreviados() {
  let elencoSerie = series
    .find(s => s.elenco.every(e => e.temAbreviacao()))
    .elenco
    .map(e => e.match(/ [a-z][.] /gi)[0][1])
    .join("");
  return `#${ elencoSerie }`;
}

console.log(descobrirSerieComTodosAbreviados());
