modulo = angular.module('modulo01', []);

modulo.controller("pokemonController", function($scope){
    $scope.pokemon = {
        nome : "charizard",
        tipo : "fogo"
    };
});
