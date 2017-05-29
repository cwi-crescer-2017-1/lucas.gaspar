modulo.controller("chatController", function($scope, chatService, $localStorage, $location){

    $scope.salvar = salvar;
    $scope.nomeAtual = $localStorage.Nome;
    
    setInterval(function(){carregarMensagens()}, 2000);
    carregarMensagens();

    function carregarMensagens(){
        if(!$localStorage.Nome){
            console.log("Não logou");
             $location.url("login");
        }
        else{
        let promise = chatService.carregarMensagens();

        promise.then(function (response) {
            $scope.mensagens = response.data;
            console.log(response);
        }); 
        console.log("NOME",$localStorage.Nome);
        }
    }

    function salvar(texto) {
        if ($scope.formEnvio.$invalid) {
            return;
        }
        let data = new Date();
        mensagem = {
            Texto: texto,
            Data:  data,
            Usuario: {
                Nome:  $localStorage.Nome,
                UrlFoto:  $localStorage.UrlFoto
            }
        }
       
       let promise =  chatService.salvarMensagem(mensagem);

       promise.then(function () {
            carregarMensagens();
            $scope.texto= "";
        });  
    }


}); 