modulo = angular.module('modulo01', []);

modulo.controller("pokemonController", function($scope){
    $scope.pokemons = [
        {
            nome: "pikachu",
            tipo: "Raio" 
        },
        {
            nome: "Charizard",
            tipo: "Fogo" 
        },
        {
            nome: "Blastoise",
            tipo: "Água" 
        },
        {
            nome: "Squirtle",
            tipo: "Água" 
        },
        {
            nome: "Raichu",
            tipo: "Raio" 
        },
        {
            nome: "Onix",
            tipo: "Pedra" 
        },
        {
            nome: "Charmander",
            tipo: "Fogo" 
        },
        {
            nome: "Rattata",
            tipo: "Roedor" 
        },
        {
            nome: "Bulbasaur",
            tipo: "Folha" 
        },
        {
            nome: "Spearow",
            tipo: "Capitão" 
        }
    ];
});