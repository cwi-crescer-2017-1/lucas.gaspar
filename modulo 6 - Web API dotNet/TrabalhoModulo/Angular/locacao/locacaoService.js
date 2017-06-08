modulo.factory('locacaoService', function($http) {  
    let urlLocacao = 'http://localhost:55484/api/locacao'; 
    let urlProduto = 'http://localhost:55484/api/produto';
    let urlPacote = 'http://localhost:55484/api/pacote';
    let urlCliente = 'http://localhost:55484/api/cliente';
    let urlItens = 'http://localhost:55484/api/item';

    function buscarProdutos() {
        return $http.get(`${urlProduto}`);
    }

    function buscarPacotes() {
        return $http.get(`${urlPacote}`);
    }

     function buscarClientes() {
        return $http.get(`${urlCliente}`);
    }

    function buscarAdicionais() {
        return $http.get(`${urlItens}`);
    }
    
    function salvar(locacao) {
        console.log(locacao);
        var objetos = JSON.parse(locacao.adicional);
        var item = [];
        for (var index = 0; index < objetos.length; index++) {
            item.push(objetos[index]);
        }
        debugger
        return $http.post(`${urlLocacao}`, 
        { 
            "DataEntregaPrevista": locacao.DataEntregaPrevista,
            "DataLocacao": locacao.DataLocacao,
            "Cliente": JSON.parse(locacao.cliente),
            "Pacote": JSON.parse(locacao.pacote),
            "Item": item,
            "Produto": JSON.parse(locacao.produto)
        });
    }

     return{
         buscarProdutos: buscarProdutos,
         buscarPacotes : buscarPacotes,
         buscarClientes : buscarClientes,
         buscarAdicionais: buscarAdicionais,
         salvar : salvar
    };
})