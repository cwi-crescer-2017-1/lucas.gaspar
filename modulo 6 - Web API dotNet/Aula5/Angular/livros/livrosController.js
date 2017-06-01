modulo.controller("livrosController", function($scope, livroService){

    carregarLivros();
    carregarLancamentos();

    function carregarLivros(){
        let promise = livroService.getLivros();

        promise.then(function (response) {
            $scope.livros = response.data;
            console.log(response);
        }); 
    }

    function carregarLancamentos() {
        let promise = livroService.getLancamentos();

        promise.then(function (response) {
            $scope.lancamentos = response.data;
            console.log(response);
        }); 
    }

}); 