modulo.factory('loginService', function($http) {
    
    let urlbase = 'http://localhost:porta/usuario';

    function cadastrar(usuario) {
        return $http.post(`${urlbase}`, usuario);
    }

    return{
        cadastrar: cadastrar
    };
})