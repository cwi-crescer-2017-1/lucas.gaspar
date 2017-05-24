modulo.controller("instrutoresController", function($scope, instrutorService, aulaService){
    $scope.excluir = excluir;
    $scope.incluir = incluir;
    $scope.preencherInstrutor = preencherInstrutor;
    
    carregarInstrutores();
    carregarAulas();

    function carregarInstrutores(){
        let promise = instrutorService.carregarInstrutores();

        promise.then(function (response) {
            $scope.instrutores = response.data;
        }); 
    }

    function carregarAulas(){
        let promise = aulaService.getAulas();

        promise.then(function (response) {
            $scope.aulas = response.data;
        }); 
    }

    function excluir(id) {
        let promise = instrutorService.excluirInstrutor(id);

        promise.then(function () {
            alert("Instrutor Excluído com sucesso");
            carregarInstrutores();
        });
    }

    function incluir (instrutor) {
        if ($scope.formInstrutor.$invalid) {
            return;
        }

        let promise = {};

        if(!$scope.instrutor.foto){
            instrutor.urlFoto = "default-user-image.png";
        }
        else {
            instrutor.urlFoto = $scope.instrutor.foto;
        }

         if (angular.isDefined(instrutor.id)){
             promise = instrutorService.alterar(instrutor);
        }
        else{
             instrutor.aula = $scope.novoInstrutor.aula;
             promise = instrutorService.salvar(instrutor);
        }

        promise.then(function () {
            carregarInstrutores();
        });

        $scope.instrutor = {};
    }

    function preencherInstrutor(instrutor) {
        console.log(instrutor);
        $scope.instrutor = angular.copy(instrutor);
    }

}); 