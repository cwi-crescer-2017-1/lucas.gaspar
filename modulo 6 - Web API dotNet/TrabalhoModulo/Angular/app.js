var modulo = angular.module('locadora', ['ngRoute','auth']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/locacao', {
      controller: 'locacaoController',
      templateUrl: 'locacao/locacao.html'
    })
    // .when('/devolucao', {
    //   controller: 'devolucaoController',
    //   templateUrl: 'devolucao/devolucao.html'
    // })
    // .when('/relatorio', {
    //   controller: 'relatorioController',
    //   templateUrl: 'relatorio/relatorio.html'
    // })
    .when('/cliente', {
      controller: 'clienteController',
      templateUrl: 'cliente/cliente.html'
    })
    .when('/login', {
      controller: 'loginController',
      templateUrl: 'login/login.html'
    })
    .otherwise({redirectTo: '/login'});
});