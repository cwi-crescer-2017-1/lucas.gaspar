package br.com.crescer.aula3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author lucas.gaspar
 */
public class Run {

    public static void main(String[] args) {
        final String url = "jdbc:oracle:thin:@localhost:1521:xe";
        final String user = "AULAJAVA";
        final String pass = "AULAJAVA";
        final String query = "SELECT * FROM PAIS";

        try (final Connection connection = DriverManager.getConnection(url, user, pass);
             final Statement statement = connection.createStatement();
             final ResultSet resultSet = statement.executeQuery(query)){
            
           System.out.println(!connection.isClosed());
            
           while(resultSet.next()){
                System.out.println(resultSet.getString("sigla"));
            }
            
       } catch (SQLException e) {
            System.err.format("SQLException: %s", e);            
       }
    }
}
