modulo.controller("livrosController", function($scope, livroService, $uibModal){

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

    $scope.assinatura = function () {
    var modalInstance = $uibModal.open({
      animation: true,
      ariaLabelledBy: 'Inscrever-se',
      //ariaDescribedBy: 'modal-body',
      templateUrl: 'livros/modalAssinatura.html',
      controller: 'modalAssinaturaController',
      controllerAs: '$ctrl'
    });
    };

}); 