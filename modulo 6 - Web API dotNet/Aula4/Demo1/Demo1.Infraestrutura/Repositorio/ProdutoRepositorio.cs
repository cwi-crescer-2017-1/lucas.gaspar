using Demo1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Infraestrutura.Repositorio
{
    public class ProdutoRepositorio
    {
        string stringConexao = "Server=13.65.101.67;User id=lucas.gaspar;Password=123456;Database=aluno12db";
        public void Criar(Produto produto)
        {

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "insert Into Produto (Nome, Preco, Estoque) Values (@nome, @preco, @estoque)";

                    comando.Parameters.AddWithValue("@nome", produto.Nome);
                    comando.Parameters.AddWithValue("@preco", produto.Preco);
                    comando.Parameters.AddWithValue("@estoque", produto.Estoque);

                    // comando.ExecuteNonQuery(); Executa e retorna só a qtd de linhas afetadas
                    //comando.ExecuteReader();  Lê o resultado de um select
                    //comando.ExecuteScalar(); Executa ocomando e retorna o primeiro resultado

                    comando.ExecuteNonQuery();
                }

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "select @@identity";
                    var result = (decimal)comando.ExecuteScalar();
                    produto.Id = (int)result;
                }
            }
        }

        public List<Produto> Listar()
        {
            var produtos = new List<Produto>();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "select Id, Nome, Preco, Estoque from Produto";

                    var dataReader = comando.ExecuteReader();

                    while (dataReader.Read())
                    {
                        var produto = new Produto();

                        produto.Id = (int)dataReader["Id"];
                        produto.Nome = (string)dataReader["Nome"];
                        produto.Preco = (decimal)dataReader["Preco"];
                        produto.Estoque = (int)dataReader["Estoque"];

                        produtos.Add(produto);
                    }
                }
            }
                return produtos;
        }
    }
}
