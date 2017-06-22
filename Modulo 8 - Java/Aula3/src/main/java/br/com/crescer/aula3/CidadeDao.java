/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package br.com.crescer.aula3;

import br.com.crescer.aula3.ConnectionUtils;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 *
 * @author lucas.gaspar
 */
public class CidadeDao {

    private static final String INSERT_CIDADE = "INSERT INTO Cidade (ID, NOME, ESTADO) VALUES (?,?,?)";
    private static final String UPDATE_CIDADE = "UPDATE CIDADE SET NOME = ?, ESTADO = ? WHERE ID = ?";
    private static final String DELETE_CIDADE = "DELETE FROM CIDADE WHERE ID = ?";
    private static final String LOAD_CIDADE = "SELECT * FROM CIDADE WHERE ID = ?";

    
    public void insert(Cidade cidade) {
        try (final PreparedStatement preparedStatement
                = ConnectionUtils.getConnection().prepareStatement(INSERT_CIDADE)) {

            preparedStatement.setInt(1, cidade.getId());
            preparedStatement.setString(2, cidade.getNome());
            preparedStatement.setInt(3, cidade.getEstado());
            
            preparedStatement.executeUpdate();
            
        } catch (final SQLException e) {
            System.err.format("SQLException: %s", e);
        }
    }

    
    public void update(Cidade cidade) {
        try (final PreparedStatement preparedStatement
                = ConnectionUtils.getConnection().prepareStatement(UPDATE_CIDADE)) {
          
            preparedStatement.setString(2, cidade.getNome());
            preparedStatement.setInt(3, cidade.getEstado());
            preparedStatement.setInt(1, cidade.getId());
            
            preparedStatement.executeUpdate();
        } catch (final SQLException e) {
            System.err.format("SQLException: %s", e);
        }
    }

    
    public void delete(Cidade cidade) {
        try (final PreparedStatement preparedStatement
                = ConnectionUtils.getConnection().prepareStatement(DELETE_CIDADE)) {
            preparedStatement.setLong(1, cidade.getId());
            preparedStatement.executeUpdate();
        } catch (final SQLException e) {
            System.err.format("SQLException: %s", e);
        }
    }

    
    public Cidade loadBy(Long id) {
        final Cidade cidade = new Cidade();
        try (final PreparedStatement preparedStatement
                = ConnectionUtils.getConnection().prepareStatement(LOAD_CIDADE)) {
            preparedStatement.setLong(1, id);
            try (final ResultSet resultSet = preparedStatement.executeQuery()) {

                while (resultSet.next()) {
                    cidade.setId(resultSet.getInt("ID"));
                    cidade.setNome(resultSet.getString("NOME"));
                    cidade.setEstado(resultSet.getInt("ESTADO"));
                    
                }
            } catch (final SQLException e) {
                System.err.format("SQLException: %s", e);
            }
        } catch (final SQLException e) {
            System.err.format("SQLException: %s", e);
        }
        return cidade;
    }

}
