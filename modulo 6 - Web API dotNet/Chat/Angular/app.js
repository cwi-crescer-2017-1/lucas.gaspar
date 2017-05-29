var modulo = angular.module('chat', ['ngRoute','ngStorage']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/chat', {
      controller: 'chatController',
      templateUrl: 'chat/chat.html'
    })
    .when('/login', {
      controller: 'loginController',
      templateUrl: 'login/login.html'
    })
    .otherwise({redirectTo: '/chat'});
});