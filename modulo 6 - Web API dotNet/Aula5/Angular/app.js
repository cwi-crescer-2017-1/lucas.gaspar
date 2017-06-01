var modulo = angular.module('editora', ['ngRoute', 'ui.bootstrap']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/livros', {
      controller: 'livrosController',
      templateUrl: 'livros/livros.html'
    })
    .otherwise({redirectTo: '/livros'});
});