// Exercicio 1
function daisyGame(a) {
    if (a % 2 == true) {
      return "Love Me";
    }
    else {
      return "Love me not";
    }
}

console.log(daisyGame(2));
console.log(daisyGame(3));

// Exercicio 2

function maiorTexto(listaTextos) {
  var maior = 0; var result;
  for (var i = 0; i < listaTextos.length; i++) {
      if (listaTextos[i].length >= maior) {
        result = listaTextos[i];
        maior = listaTextos[i].length;
      }
  }
  return result;
}

var texto = ["Lucas", "Inconstitucionalissimamente", "Apontador", "oi"];
console.log(maiorTexto(texto));

// Exercicio 3
var arraystrings = [ 'bernardo', 'nunes', 'fabrício', 'ben-hur', 'carlos'];
var funcao = function(instrutor){
  console.log("olá querido instrutor: ", instrutor);
}

function imprime(array, funcao) {
    if (typeof funcao === "function")
    {
      for (var i = 0; i < arraystrings.length; i++) {
        funcao(arraystrings[i]);
      }
    } else {
      console.log("informe uma função no segundo parâmetro, por favor");
    }
}
imprime(arraystrings, funcao);
imprime(arraystrings, 3.14);

//Exercício 4
var segundavez = 0, b;
function somar(a) {
     segundavez++;
     if (segundavez === 2){
       segundavez = 0;
       return a+b;
     }
     else {
      b = a;
     }
}
console.log(somar(5), somar(5));

// Exercicio 5
function fibosum(n) {
    let arrayfibo = [0], result=0;
    for (var i = 0; i < n; i++) {
        if(i===0 || i ===1){
          arrayfibo[i] = 1;
        } else {
          arrayfibo[i] = arrayfibo[i-1] + arrayfibo[i-2];
        }
    }
    for (var j = 0; j < i; j++) {
      result = result + arrayfibo[j];
    }

    return result;
}

console.log(fibosum(7));

// Exercicio 6

var precos = [5.16, 2.12, 1.15, 3.11, 17.5];

function queroCafe(mascada, precos) {
    let resp = [];
    precos.sort(function(a, b){return a-b});
      for (var i = 0; i < precos.length; i++) {
        if (mascada >= precos[i]) {
            resp.push(precos[i]);
        }
    }
    return resp.toString();
}
console.log(queroCafe(5,precos));

//exercicio 6 com ordenação no braço
