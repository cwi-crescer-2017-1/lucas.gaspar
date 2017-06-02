modulo.controller("modalAssinaturaController", function($scope){

    $scope.fechar = fechar;

    function fechar() {
        $modalStack.dismissAll(reason);
    }

}); 