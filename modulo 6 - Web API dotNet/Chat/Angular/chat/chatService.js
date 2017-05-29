modulo.factory('chatService', function($http) {
    

    function carregarMensagens() {
        return $http.get(`http://localhost:24206/api/Mensagens`);
    }
    
    function salvarMensagem(mensagem) {
        console.log("NA SERVICE", mensagem);
        return $http.post(`http://localhost:24206/api/Mensagens`, mensagem);
    }

    return{
         carregarMensagens: carregarMensagens,
         salvarMensagem: salvarMensagem
    };
})