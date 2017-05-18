modulo = angular.module('modulo01', []);

modulo.controller("dateController", function($scope, $filter){
    
    $scope.formatarData = formatarData;

    function formatarData(data) {
        let dataformatada = data.split("/");
        let dataConvertida = new Date(dataformatada[2],dataformatada[1]-1, dataformatada[0]);
        console.log(dataArray);
        data = new Date(data);    
        $scope.dataformatada = $filter('date')(data, 'shortDate');
    }
});