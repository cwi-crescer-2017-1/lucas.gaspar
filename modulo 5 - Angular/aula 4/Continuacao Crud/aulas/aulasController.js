modulo.controller("aulasController", function($scope, aulaService){
    
    $scope.excluir = excluir;
    $scope.salvar = salvar;
    $scope.editar = editar;
    
    carregarAulas();

    function carregarAulas(){
        let promise = aulaService.getAulas();

        promise.then(function (response) {
            $scope.aulas = response.data;
        }); 
    }

    function excluir(id) {
        let promise = aulaService.deleteAula(id);

        promise.then(function () {
            carregarAulas();
            alert("Item excluído com sucesso");
        });
    }

    function salvar(aula) {
        if ($scope.formAula.$invalid) {
            return;
        }
        let promise = {};

        if (angular.isDefined(aula.id)){
            promise = aulaService.alterar(aula);
        }
        else{
            promise = aulaService.salvar(aula)
        }

        promise.then(function () {
            alert("Salvo com sucesso");
            carregarAulas();
        });

        $scope.aulaNova = {};
    }

    function editar(aula) {
        $scope.aulaNova =  angular.copy(aula);
    }

}); 