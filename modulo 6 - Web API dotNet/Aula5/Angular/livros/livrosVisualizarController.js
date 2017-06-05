modulo.controller("livrosVisualizarController", function($scope, $routeParams, livroService){
   
   console.log("ID RECEBIDO: "+ $routeParams.isbn);

   buscar($routeParams.isbn);

    function buscar(isbn) {
        let promise = livroService.getLivroDetalhado(isbn);

        promise.then(function (response) {
            $scope.livroCompleto = response.data;
            console.log(response);
        }); 
    }

}); 