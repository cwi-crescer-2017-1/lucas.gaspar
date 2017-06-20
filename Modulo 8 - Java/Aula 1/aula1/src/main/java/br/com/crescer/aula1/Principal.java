package br.com.crescer.aula1;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;
 
public class Principal {
    public static void main(String[] args) {
        try (final Scanner scanner = new Scanner(System.in)) {
            System.out.println("Informe Uma data");
            String data = scanner.nextLine();
            System.out.println("Informe os Dias");
            int dias = scanner.nextInt();
            
            Calendar calendar = Calendar.getInstance();
            /*calendar.setTime(FORMAT.parse(data));*/
            calendar.add(Calendar.DAY_OF_YEAR, dias);          
        } catch (Exception e) {
            //...
        }
        
    }
}
