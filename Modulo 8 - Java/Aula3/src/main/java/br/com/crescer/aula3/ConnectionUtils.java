/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.aula3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author lucas.gaspar
 */
public final class ConnectionUtils {
     private static String url = "jdbc:oracle:thin:@localhost:1521:xe";
     private static String user = "AULAJAVA";
     private static String pass = "AULAJAVA";
    static Connection connection;
    
    private ConnectionUtils(){
     
    }
    
    public static Connection getConnection() throws SQLException{
       return DriverManager.getConnection(url, user, pass);
    }
    
     
}
