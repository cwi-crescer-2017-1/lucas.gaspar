var modulo = angular.module('crud', ['ngRoute']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/aulas', {
      controller: 'aulasController',
      templateUrl: 'aulas/aulas.html'
    })
    .when('/instrutores', {
      controller: 'instrutoresController',
      templateUrl: 'instrutores/instrutores.html'
    })
    .otherwise({redirectTo: '/aulas/aulas'});
});