modulo.controller("relatorioController", function($scope, relatorioService, $localStorage){
    $scope.relatorioAtraso = relatorioAtraso;
    $scope.verificaPermissao = verificaPermissao;
    $scope.relatorioMensal = relatorioMensal;

    function relatorioAtraso() {
        let promise = relatorioService.relatorioAtraso();

        promise.then(function (response) {
            $scope.atrasados = response.data.dados;
            console.log(response);
        });
    }

    function relatorioMensal() {
        let promise = relatorioService.relatorioMensal();

        promise.then(function (response) {
            $scope.mensal = response.data.dados;
            console.log(response);
        });
    }

    function verificaPermissao() {
        if ($localStorage.usuarioLogado.Permissao=='Administrador') {
            return true;
        }
        else{
            return false;
        }
    }

}); 