modulo.controller("clienteController", function($scope, clienteService, $location){
    $scope.salvar = salvar;
    function salvar(cliente) {
        if($scope.formCliente.$invalid) {
            console.log("Formulário inválido");
            return;
        }
        
        let promise = clienteService.salvar(cliente);
        promise.then(function () {
            alert("Salvo com sucesso");
            $location.path('/locacao');
        });
    }
}); 