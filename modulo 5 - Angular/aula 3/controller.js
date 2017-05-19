modulo = angular.module('modulo01', []);

modulo.controller("controller", function($scope, $filter){
    let instrutores = [
  {
    nome: 'Bernardo',
    sobrenome: 'Rezende',
    idade: 30,
    email: 'bernardo@cwi.com.br',
    jaDeuAula: true,
    aula: 'OO'
  }
    ];
    let aulas = [
    'OO',
    'HTML e CSS',
    'Javascript',
    'AngularJS',
    'Banco de Dados I'
  ];
    $scope.instrutores = instrutores;
    $scope.aulas = aulas;
    $scope.addInstrutor = addInstrutor;

    function addInstrutor() {
         if($scope.meuFormulario.$invalid){
             console.log("inválido");
             return;
         }
         let nome = $scope.primeiroNome;
         let sobrenome = $scope.ultimoNome;
         let idade = $scope.idade;
         let email = $scope.email;
         let aulaSelecionada = $scope.aulaSelecionada;
         let deuAula = $scope.deuAula;

         let novoInstrutor = {
            nome: nome,
            sobrenome: sobrenome,
            idade: idade,
            email: email,
            jaDeuAula: deuAula || false,
            aula: aulaSelecionada
         };

         $scope.novoInstrutor = novoInstrutor;
         $scope.instrutores.push(novoInstrutor);
    }
});