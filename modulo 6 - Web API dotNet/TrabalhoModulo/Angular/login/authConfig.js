angular.module('locadora').constant('authConfig', {

    // Obrigatória - URL da API que retorna o usuário
    urlUsuario: 'http://localhost:55484/api/acessos/usuario',

    // Obrigatória - URL da aplicação que possui o formulário de login
    urlLogin: '/login',

    // Opcional - URL da aplicação para onde será redirecionado (se for informado) após o LOGIN com sucesso
    //urlPrivado: '/administrativo',

    // Opcional - URL da aplicação para onde será redirecionado (se for informado) após o LOGOUT
    urlLogout: '/login'
});