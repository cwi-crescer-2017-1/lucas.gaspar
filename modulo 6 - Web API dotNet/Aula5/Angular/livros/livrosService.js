modulo.factory('livroService', function($http) {
    
    let urlBase = "http://localhost:58924/api/livros";
    return {
        getLivros : getLivros,
        getLancamentos : getLancamentos,
        getLivroDetalhado: getLivroDetalhado
    };

    function getLivros() {
        return $http.get(`${urlBase}`);
    }

    function getLancamentos() {
        return $http.get(`${urlBase}/lancamentos`);
    }

    function getLivroDetalhado(isbn) {
        console.log(isbn);
        return $http.get(`${urlBase}/${isbn}`);
    }
})