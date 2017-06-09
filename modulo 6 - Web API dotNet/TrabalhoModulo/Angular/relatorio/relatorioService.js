modulo.factory('relatorioService', function($http) {  
    let urlRelatorio = 'http://localhost:55484/api/relatorio';

    function relatorioAtraso() {
        return $http.get(`${urlRelatorio}`);
    }

     function relatorioMensal() {
        return $http.get(`${urlRelatorio}/mensal`);
    }

     return{
         relatorioAtraso: relatorioAtraso,
         relatorioMensal: relatorioMensal
    };
})