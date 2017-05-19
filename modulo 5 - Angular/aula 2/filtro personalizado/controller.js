modulo = angular.module('modulo01', []);

modulo.filter('mascada', function () {
    return function (nome) {
        return nome.replace(/(nunes)/i, "$ $1 $");
    }
});

modulo.controller("filtroController", function ($scope) {
    let instrutores = [{
        nome: 'Pedro (PHP)',
        aula: [{
            numero: 3,
            nome: 'HTML e CSS'
        }]
    },
    {
        nome: 'Zanatta',
        aula: [{
            numero: 5,
            nome: 'AngularJS'
        }]
    },
    {
        nome: 'Bernardo',
        aula: [{
            numero: 1,
            nome: 'OO'
        },
        {
            numero: 4,
            nome: 'Javascript'
        }
        ]
    },
    {
        nome: 'Nunes',
        aula: [{
            numero: 2,
            nome: 'Banco de Dados I'
        }]

    }
    ];
    $scope.instrutores = instrutores;
});
