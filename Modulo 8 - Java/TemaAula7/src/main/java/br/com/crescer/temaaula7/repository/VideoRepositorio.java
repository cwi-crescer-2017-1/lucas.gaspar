/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.temaaula7.repository;

import br.com.crescer.temaaula7.entity.Video;
import java.io.Serializable;
import org.springframework.data.repository.CrudRepository;

/**
 *
 * @author lucas.gaspar
 */
public interface VideoRepositorio extends CrudRepository<Video, Long>{
    
}
