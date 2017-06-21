package br.com.crescer.tema1;

import br.com.crescer.tema1.CalendarUtils.DiaSemana;
import java.math.BigDecimal;
import java.util.Date;
import java.util.Map;

public class Testes {
   public static void main(String[] args) {
        String testeString = "Lucas Gaspar", inverter;
        boolean test;
        int numero;
        StringManipulation sm = new StringManipulation();
        MeuCalendarioUtils mcu = new MeuCalendarioUtils();
        
        //Primeiro método
        test = sm.isEmpty(testeString);
        System.out.println(test);
        test = sm.isEmpty("  ");
        System.out.println(test);
        
        // Segundo método
        inverter = sm.inverter(testeString);
        System.out.println(inverter);   
        inverter = sm.inverter("   ");
        System.out.println(inverter);
        
        // Terceiro Método
        numero = sm.contaVogais(testeString);
        System.out.println(numero);
        numero = sm.contaVogais("casáá");
        System.out.println(numero);
        
        // Quarto Método
        
        test = sm.isPalindromo(testeString);
        System.out.println(test);
        
        test = sm.isPalindromo("ovo");
        System.out.println(test);
        
        //Exercício 2
        //A
        DiaSemana dia = mcu.diaSemana(new Date());
        System.out.println(dia);
        
        //B
        String diferenca = mcu.tempoDecorrido(new Date(96,00,01));
        System.out.println(diferenca);
        
        MeuParcelator mp = new MeuParcelator();
        
        Map<String, BigDecimal> map = mp.calcular(new BigDecimal(1000), 10, 10, new Date());
        
        map.entrySet().forEach(e ->{
            System.out.println("Map" + e.getKey() + " " + e.getValue());  
        });
        
        
    } 
}
