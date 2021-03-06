/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.service;

import br.com.crescer.social.Repositories.UsuarioRepositorio;
import br.com.crescer.social.entity.Usuario;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;

/**
 *
 * @author lucas.gaspar
 */
@Service
public class UsuarioService {
    @Autowired
    UsuarioRepositorio usuarioRepositorio;
    
    public Usuario getUsuarioById(Long id){
        return usuarioRepositorio.findOne(id);
    }
    
    public void CadastrarUsuario(Usuario u) {
        u.setSenha(new BCryptPasswordEncoder().encode(u.getSenha()));
        usuarioRepositorio.save(u);
    }
    
    public Usuario getByEmail(String email) {
        return usuarioRepositorio.findByEmail(email);
    }
}
