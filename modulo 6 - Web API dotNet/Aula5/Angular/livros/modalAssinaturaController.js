modulo.controller("modalAssinaturaController", function($scope, $uibModalInstance){
    var $ctrl = this;

    $scope.cancelar = cancelar;

    function cancelar() {
        $uibModalInstance.dismiss('cancel');
     };

}); 