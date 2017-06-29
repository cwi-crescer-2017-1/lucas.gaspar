modulo.controller("loginController", function($scope){
    $scope.qualform=1;
    $scope.alteraFormExibidoEmTela=alteraFormExibidoEmTela;
    function alteraFormExibidoEmTela() {
      $scope.qualform = $scope.qualform === 1 ? 2 : 1;
    }
    $scope.login = function (usuario) {
  };
}); 