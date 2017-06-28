/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.aula7.Controllers;

import br.com.crescer.aula7.Ator;
import br.com.crescer.aula7.Servicos.AtorService;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author lucas.gaspar
 */
@RestController
public class AutorRest {
  @Autowired
  AtorService service;
  
//    List<Ator> getAutores() {
//        return AtorService.findAllAtor();
//    }
    
}
