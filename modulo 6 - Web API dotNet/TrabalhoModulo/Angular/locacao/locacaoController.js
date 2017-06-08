modulo.controller("locacaoController", function($scope, locacaoService){
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
}); 