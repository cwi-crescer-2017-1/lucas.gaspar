modulo.controller("clienteController", function($scope, clienteService){
    $scope.salvar = salvar;
    function salvar(cliente) {
        if($scope.formCliente.$invalid) {
            console.log("Formulário inválido");
            return;
        }
        
        let promise = clienteService.salvar(cliente);
        promise.then(function () {
            console.log("Salvo com sucesso");
            $scope.cliente = "";
        });
    }
}); 