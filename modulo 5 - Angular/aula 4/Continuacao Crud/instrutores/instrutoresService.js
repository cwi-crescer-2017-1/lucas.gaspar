modulo.factory('instrutorService', function($http) {
    
    let urlbase = 'http://localhost:3000';

    function carregarInstrutores() {
        return $http.get(`${urlbase}/instrutor`);
    }

    function excluirInstrutor(id) {
        return $http.delete(`${urlbase}/instrutor/${id}`);
    }

    function salvar(instrutor) {
        console.log("chamou sakvar instrutor");
        return $http.post(`${urlbase}/instrutor`, instrutor);
    }

    function alterar(instrutor) {
        return $http.put(`${urlbase}/instrutor/${instrutor.id}`, instrutor);
    }

    return{
         carregarInstrutores: carregarInstrutores,
         excluirInstrutor: excluirInstrutor,
         salvar: salvar,
         alterar: alterar
    };
})