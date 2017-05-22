modulo = angular.module('crud', ['ngRoute']);

modulo.config(function($routeProvider) {
    $routeProvider
    .when('/aulas', {
      controller: 'aulasController',
      templateUrl: 'aulas.html'
    })
    .when('/instrutores', {
      controller: 'instrutoresConstroller',
      templateUrl: 'instrutores.html'
    })
    .otherwise({redirectTo: '/aulas.html'});
});

modulo.controller("principalController", function($scope, $filter){
    $scope.adicionarAula = adicionarAula;
    $scope.excluirAula = excluirAula;
    $scope.editarAula = editarAula;
    $scope.alterarAula = alterarAula;
    $scope.aulaEditar={};

    $scope.incluirInstrutor = incluirInstrutor;
    $scope.editarInstrutor = editarInstrutor;
    $scope.instrutorEditar = {};
    $scope.alterarInstrutor = alterarInstrutor;
    $scope.excluirInstrutor = excluirInstrutor;

    let instrutores = [
  {
    id: 0,
    nome: 'Bernardo',                     
    sobrenome: 'Café',        
    idade: 30,                      
    email: 'bernardo@cwi.com.br',     
    dandoAula: true,                  
    aula: [1, 4],                     
    urlFoto: 'http://foto.com/3.png' 

  },

  {
    id: 1,
    nome: 'Lucas',                     
    sobrenome: 'Gaspar',        
    idade: 21,                      
    email: 'lucas@cwi.com.br',     
    dandoAula: false,                  
    aula: [2],                     
    urlFoto: 'http://foto.com/3.png' 

  }

    ];
     $scope.instrutores = instrutores;

    let aulas = [
    {   
         id: 0,
         nome: 'OO' 
    },
    {   
         id: 1,
         nome: 'Angular' 
    }
  ];
  $scope.aulas = aulas;

    function adicionarAula() {

        if($scope.meuFormulario.$invalid){
            return;
        }

        let novaAula = {
            id : $scope.aulas.length,
            nome : $scope.nomeAula
        }
        let jaExiste = false;

         $scope.aulas.forEach(function(a){
             if (a.nome.toLowerCase() === novaAula.nome.toLowerCase()){
                jaExiste = true;
             }
         });

        if(jaExiste === false){
             $scope.aulas.push(novaAula);
        }else
         alert("Essa aula já existe");
  

    }

    function excluirAula(id){
        $scope.aulas.forEach(function(e){
            if (id === e.id) {
                let index = $scope.aulas.indexOf(e);
                $scope.aulas.splice(index, 1);
                alert("Aula Excluída com sucesso");
            }
        });
    }

    function editarAula(aula){ //Apenas chama a modal de alteração com o valor correto
         $scope.aulaEditar = angular.copy(aula);
    }

    function alterarAula(aulaEditada){
        if($scope.formEditarAula.$invalid){
            return;
        }

        $scope.aulas.forEach(function(a){
            if(a.id === aulaEditada.id){
                a.nome = aulaEditada.nome;
                alert("Alteração realizada com sucesso");
            }
        });
    }

    function incluirInstrutor(instrutor){   
        if($scope.formInstrutor.$invalid){
            console.log("inválido");
            return;
        }

        instrutor.id = $scope.instrutores.length;
        if(!$scope.instrutor.foto){
            instrutor.urlFoto = "default-user-image.png";
        }
        else {
            instrutor.urlFoto = $scope.instrutor.foto;
        }
        instrutor.aula = [];
        instrutor.aula.push($scope.novoInstrutor.aula);

         let jaExisteNome = false;
         let jaExisteEmail = false;

         $scope.instrutores.forEach(function(i){
             if (i.email === instrutor.email){
                jaExisteEmail = true;
             }
             else{
                 if(i.nome.toLowerCase() === instrutor.nome.toLowerCase()){
                     jaExisteNome = true;
                 }
             }
         });

        if(jaExisteNome === false){
            if(jaExisteEmail === false){
                $scope.instrutores.push(instrutor); 
                alert("Instrutor cadastrado com sucesso"); 
            }
            else{
                alert("Email já está sendo utilizado");
            }     
        } else{
        alert("instrutor já cadastrado");
        }
    }

    function editarInstrutor(instrutor){ //Apenas chama a modal de alteração com o valor correto
         $scope.instrutorEditar = angular.copy(instrutor);
    }

    function alterarInstrutor(instrutor){
        if($scope.formEditarInstrutor.$invalid){
            return;
        }
        else{
        
        $scope.instrutores.forEach(function(i){
            if(i.id === instrutor.id){
                $scope.instrutores[i.id] = angular.copy(instrutor);
                 alert("Usuário alterado com sucesso");
            }
        });
            
        }
    }

    function excluirInstrutor(id){
        $scope.instrutores.forEach(function(i){
            if (id === i.id) {
                let index = $scope.instrutores.indexOf(i);
                if(i.dandoAula === true){
                    alert("Não é possível excluir este instrutor, está dando aula.");
                }
                else{
                      $scope.instrutores.splice(index, 1);
                      alert("Usuário Excluído com sucesso");
                }
            }
        });
    }

}); 