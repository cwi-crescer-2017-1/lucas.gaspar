modulo.controller("locacaoController", function($scope, locacaoService, authService, $location){

    $scope.salvar = salvar;
    $scope.deslogar = deslogar;
    $scope.relatorio = relatorio;
    $scope.devolucao = devolucao;

    buscarCliente();
    buscarProduto();
    buscarPacotes();
    buscarAdicionais();

    function buscarCliente() {
        let promise = locacaoService.buscarClientes();

        promise.then(function (response) {
            $scope.clientes = response.data.dados;
        }); 
    }
    
    function buscarProduto() {
        let promise = locacaoService.buscarProdutos();

        promise.then(function (response) {
            $scope.produtos = response.data.dados;
        }); 
    }

    function buscarPacotes() {
        let promise = locacaoService.buscarPacotes();

        promise.then(function (response) {
            $scope.pacotes = response.data.dados;
        }); 
    }

    function buscarAdicionais() {
        let promise = locacaoService.buscarAdicionais();

        promise.then(function (response) {
            $scope.adicionais = response.data.dados;
        }); 
    }

    function salvar(locacao) {
        if ($scope.formLocacao.$invalid) {
            console.log("Errrrrou");
            return;
        }
        let promise = locacaoService.salvar(locacao);

        promise.then(function (response) {
            alert("Salvo");
            $scope.locacao = {};
        });

    }

    function deslogar() {
        authService.logout();
    }

    function relatorio() {
        $location.path('/relatorio');
    }

    function devolucao() {
        $location.path('/devolucao');
    }
}); 