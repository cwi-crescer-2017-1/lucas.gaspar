/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.temaaula7.controller;

import br.com.crescer.temaaula7.entity.Genero;
import br.com.crescer.temaaula7.service.GeneroService;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author lucas.gaspar
 */
@RestController
@RequestMapping("/genero")
public class GeneroController {
    @Autowired
    GeneroService service;
    
    @GetMapping
    public List<Genero> getGeneros(){
        return service.getGeneros();
    }
    
    @PostMapping
    public void Genero(@RequestBody Genero g){
        service.PostGenero(g);
    }
}
