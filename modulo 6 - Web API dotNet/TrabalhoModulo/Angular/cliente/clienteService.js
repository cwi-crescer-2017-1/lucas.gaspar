modulo.factory('clienteService', function($http) {
    
    let urlbase = 'http://localhost:55484/api/cliente';

    function salvar(cliente) {
        return $http.post(`${urlbase}`, cliente);
    }
      return{
        salvar: salvar
    };
})