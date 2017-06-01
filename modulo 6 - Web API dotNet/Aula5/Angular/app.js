var modulo = angular.module('editora', ['ngRoute', 'ui.bootstrap','ngAnimate']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/livros', {
      controller: 'livrosController',
      templateUrl: 'livros/livros.html'
    })
    .otherwise({redirectTo: '/livros'});
});