modulo.factory('devolucaoService', function($http) {
    
    let urlbase = 'http://localhost:55484/api/locacao/devolucao';

    function buscarLivrosASeremDevolvidos() {
        return $http.get(`${urlbase}`);
    }

    function devolverLocacao(locacao) {
        return $http.put(`${urlbase}`,locacao);
    }
    
      return{
        buscarLivrosASeremDevolvidos: buscarLivrosASeremDevolvidos,
        devolverLocacao: devolverLocacao
    };
})