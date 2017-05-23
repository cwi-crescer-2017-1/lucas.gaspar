modulo.factory('aulaService', function($http) {
    
    let urlbase = 'http://localhost:3000';

    function getAulas() {
        return $http.get(`${urlbase}/aula`);
    }

    function deleteAula(id) {
        return $http.delete(`${urlbase}/aula/${id}`);
    }

    function salvar(aula) {
        return $http.post(`${urlbase}/aula`, aula);
    }

    function alterar(aula) {
        return $http.put(`${urlbase}/aula/${aula.id}`, aula);
    }

    return{
        getAulas: getAulas,
        deleteAula: deleteAula,
        salvar: salvar,
        alterar: alterar
    };
})