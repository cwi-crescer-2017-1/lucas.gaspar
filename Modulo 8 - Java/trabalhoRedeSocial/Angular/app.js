var modulo = angular.module('redeSocial', ['ngRoute','auth']);
modulo.config(function($routeProvider) {
    $routeProvider
    .when('/login', {
      controller: 'loginController',
      templateUrl: 'login/login.html'
    })
    .otherwise({redirectTo: '/login'});
});