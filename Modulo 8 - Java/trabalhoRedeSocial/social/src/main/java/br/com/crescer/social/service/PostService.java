/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.service;

import br.com.crescer.social.Repositories.PostRepositorio;
import br.com.crescer.social.Repositories.UsuarioRepositorio;
import br.com.crescer.social.entity.Post;
import br.com.crescer.social.entity.Usuario;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author lucas.gaspar
 */
@Service
public class PostService {
    @Autowired
    PostRepositorio postRepositorio;
    
    public List<Post> findAllByUser(Long id){
        return (List<Post>)postRepositorio.findAll();
    }
    
}
