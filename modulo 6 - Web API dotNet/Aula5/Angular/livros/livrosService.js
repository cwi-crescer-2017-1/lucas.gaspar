modulo.factory('livroService', function($http) {
    
    let urlBase = "http://localhost:58924/api/livros";
    return {
        getLivros : getLivros,
        getLancamentos : getLancamentos 
    };

    function getLivros() {
        return $http.get(`${urlBase}`);
    }

    function getLancamentos() {
        return $http.get(`${urlBase}/lancamentos`);
    }
})