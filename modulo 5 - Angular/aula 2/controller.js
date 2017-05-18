modulo = angular.module('modulo01', []);

modulo.controller("dateController", function($scope, $filter){
    
    $scope.formatarData = formatarData;

    function formatarData(data) {
        data = new Date(data);    
        $scope.dataformatada = $filter('date')(data, 'shortDate');
    }
});