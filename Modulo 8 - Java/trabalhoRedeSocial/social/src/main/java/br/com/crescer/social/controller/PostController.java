/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.controller;

import br.com.crescer.social.entity.Post;
import br.com.crescer.social.entity.Usuario;
import br.com.crescer.social.service.PostService;
import br.com.crescer.social.service.UsuarioService;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author lucas.gaspar
 */
@RestController
@RequestMapping("/posts")
public class PostController {
    @Autowired
    private PostService postService;
  
    @GetMapping
    public List<Post> findAllByUser(@PathVariable("id") Long id) {
        return postService.findAllByUser(id);
    }
    
}
