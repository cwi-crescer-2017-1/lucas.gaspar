var modulo = angular.module('editora', ['ngRoute', 'ui.bootstrap','auth']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/livros', {
      controller: 'livrosController',
      templateUrl: 'livros/livros.html'
    })
    .when('/livros/visualizar/:isbn', {
      controller: 'livrosVisualizarController',
      templateUrl: 'livros/livrosDetalhe.html'
    })
    .when('/login', {
      controller: 'loginController',
      templateUrl: 'login/login.html'
    })
     .when('/administrativo', {
       controller: 'curdLivrosController',
      templateUrl: 'administrativo/crudLivros.html',
      // resolve: {
      //   autenticado: function (authService) {
      //     return authService.isAutenticadoPromise();
      //   }
      // }
    })
    .otherwise({redirectTo: '/livros'});
});