/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.Repositories;

import br.com.crescer.social.entity.Post;
import br.com.crescer.social.entity.Usuario;
import org.springframework.data.repository.CrudRepository;

/**
 *
 * @author lucas.gaspar
 */
public interface PostRepositorio extends CrudRepository<Post, Long> {
    
}
