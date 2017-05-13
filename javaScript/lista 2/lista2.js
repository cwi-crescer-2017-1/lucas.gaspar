// Exercicio 1 faltou verificar se a série tem algo null
function seriesInvalidadas(series) {
    let resp = [];
    let anoAtual = new Date();
    anoAtual = anoAtual.getFullYear();
    for (let i = 0; i < series.length; i++) {
        if (series[i].anoEstreia > anoAtual) {
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

// Exericio 7 faltou ordenar pelo último nome

function creditosIlluminatis (serie) {
    let diretores = [];
    let elenco = [];
    let ultimoNome = [];
    let primeironome = [];

    for (let i = 0; i < serie.diretor.length; i++) {
        diretores.push(serie.diretor[i]);
    }

    for (let i = 0; i < serie.elenco.length; i++) {
        elenco.push(serie.elenco[i]);
    }

    for (let i = 0; i < serie.diretor.length; i++) {
        ultimoNome[i] = diretores[i].split(" ").pop();
        primeironome[i] = diretores[i].split(' ').slice(0, -1);
    }
     return primeironome;
}

creditosIlluminatis(series[0]);
// console.log(creditosIlluminatis(series[0]));

// Exercicio 8
