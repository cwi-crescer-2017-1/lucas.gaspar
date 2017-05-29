modulo.controller("loginController", function($scope, $localStorage, $location){

    $scope.logar = logar;

    function logar() {
        $localStorage.Nome = $scope.Username;
        $localStorage.UrlFoto =  $scope.UrlFoto;
        $location.url("chat/chat.html");
    }
}); 