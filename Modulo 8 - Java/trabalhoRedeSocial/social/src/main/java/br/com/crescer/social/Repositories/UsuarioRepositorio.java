/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.social.Repositories;

import br.com.crescer.social.entity.Usuario;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.data.repository.query.Param;

/**
 *
 * @author lucas.gaspar
 */
public interface UsuarioRepositorio extends CrudRepository<Usuario, Long>{

    public Usuario findByEmail(String email);
    
}
