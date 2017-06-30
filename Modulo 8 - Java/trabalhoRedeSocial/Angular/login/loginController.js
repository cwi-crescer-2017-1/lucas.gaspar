modulo.controller("loginController", function($scope, loginService, authService){
    $scope.qualform=1;
    $scope.alteraFormExibidoEmTela=alteraFormExibidoEmTela;
    $scope.cadastrar = cadastrar;

    function alteraFormExibidoEmTela() {
      $scope.qualform = $scope.qualform === 1 ? 2 : 1;
    }

    $scope.login = function (usuario) {

    authService.login(usuario)
      .then(
        function (response) {
          console.log(response);
          alert('Login com sucesso!');

        },
        function (response) {
          console.log(response);
          alert('Erro no Login!');
        });
  };

    function cadastrar(usuario) {
      if ($scope.formCadastro.$invalid) {
            return;
      }
      else{
        let promise = loginService.cadastrar(usuario)
      }
    }

}); 