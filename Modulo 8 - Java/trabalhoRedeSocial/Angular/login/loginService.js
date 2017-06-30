modulo.factory('loginService', function($http) {
    
    let urlbase = 'http://localhost:9090/usuario/cadastrar';

    function cadastrar(usuario) {
        return $http.post(`${urlbase}`, usuario);
    }

    return{
        cadastrar : cadastrar
    };
})