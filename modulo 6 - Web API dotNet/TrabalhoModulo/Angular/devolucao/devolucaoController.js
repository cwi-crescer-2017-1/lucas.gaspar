modulo.controller("devolucaoController", function($scope, devolucaoService){
    buscarLivrosASeremDevolvidos();
    $scope.devolverLocacao = devolverLocacao;

    function buscarLivrosASeremDevolvidos() {
        let promise = devolucaoService.buscarLivrosASeremDevolvidos();

        promise.then(function (response) {
            $scope.mensal = response.data.dados;
            console.log(response);
        });
    }

    function devolverLocacao(locacao) {
        let promise = devolucaoService.devolverLocacao(locacao);

        promise.then(function (response) {
            console.log("DEVOLVIDO",response);
             buscarLivrosASeremDevolvidos();
        });
    }
}); 