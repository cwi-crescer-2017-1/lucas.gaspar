/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.temaaula7.service;

import br.com.crescer.temaaula7.entity.Genero;
import br.com.crescer.temaaula7.repository.GeneroRepositorio;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author lucas.gaspar
 */
@Service
public class GeneroService {
    @Autowired
    GeneroRepositorio generoRepositorio;
    
    public List<Genero> getGeneros(){
        return (List)generoRepositorio.findAll();
    }

    public void PostGenero(Genero g) {
        generoRepositorio.save(g);
    }
}
