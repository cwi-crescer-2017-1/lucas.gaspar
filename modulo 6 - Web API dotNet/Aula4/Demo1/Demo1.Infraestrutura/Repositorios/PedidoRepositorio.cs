using Demo1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.Infraestrutura.Repositorios
{
    public class PedidoRepositorio : IPedidoRepositorio
    {

        string stringConexao =
                        @"Server=13.65.101.67;
                        User Id=lucas.gaspar;
                        Password=123456;
                        Database=aluno12db";
        // pensar onde colocar para não repetir

        public void Alterar(Pedido pedido)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText =
                        "Update Pedido set NomeCliente = @nome WHERE id = @idPedido";

                    comando.Parameters.AddWithValue("@nome", pedido.NomeCliente);
                    comando.Parameters.AddWithValue("@idPedido", pedido.Id);
                    comando.ExecuteNonQuery();
                }

                using (var comando = conexao.CreateCommand())
                {
                    foreach (var p in pedido.Itens)
                    {
                        comando.CommandText =
                        "DELETE from ItemPedido WHERE PedidoId = @pedidoId";

                        comando.Parameters.AddWithValue("@pedidoId", pedido.Id);
                        comando.ExecuteNonQuery();

                    }
                }

                using (var comando = conexao.CreateCommand())
                {
                    foreach (var p in pedido.Itens)
                    {
                        comando.CommandText =
                        @"INSERT INTO ItemPedido (PedidoId, ProdutoId, Quantidade) 
                        VALUES (@pedidoId, @produtoId, @quantidade)";

                        comando.Parameters.AddWithValue("@pedidoId", pedido.Id);
                        comando.Parameters.AddWithValue("@produtoId", p.ProdutoId);
                        comando.Parameters.AddWithValue("@quantidade", p.Quantidade);
                        comando.ExecuteNonQuery();

                        //p.ValidarBaixa(p.Quantidade);

                    }
                }

                using (var comando = conexao.CreateCommand())
                {
                    foreach (var p in pedido.Itens)
                    {
                        comando.CommandText =
                            @"UPDATE PRODUTO SET Estoque = Estoque - @quantidade WHERE Id = @id";

                        comando.Parameters.AddWithValue("@quantidade", p.Quantidade);
                        comando.Parameters.AddWithValue("@id", p.ProdutoId);

                        comando.ExecuteNonQuery();

                    }
                }

               

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "SELECT @@IDENTITY";

                    var result = (decimal)comando.ExecuteScalar();
                    var ultimoItemPedido = result;
                }
            }
        }

        public void Criar(Pedido pedido)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                // Executa o INSERT
                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText =
                        @"INSERT INTO Pedido (NomeCliente) 
                        VALUES (@nome)";

                    comando.Parameters.AddWithValue("@nome", pedido.NomeCliente);
                    comando.ExecuteNonQuery();
                }

                // Obtém o último ID criado
                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "SELECT @@IDENTITY";

                    var result = (decimal)comando.ExecuteScalar();
                    pedido.Id = (int)result;
                }

                using (var comando = conexao.CreateCommand())
                {
                    foreach (var p in pedido.Itens)
                    {
                        comando.CommandText =
                        @"INSERT INTO ItemPedido (PedidoId, ProdutoId, Quantidade) 
                        VALUES (@pedidoId, @produtoId, @quantidade)";

                        comando.Parameters.AddWithValue("@pedidoId", pedido.Id);
                        comando.Parameters.AddWithValue("@produtoId", p.ProdutoId);
                        comando.Parameters.AddWithValue("@quantidade", p.Quantidade);
                        comando.ExecuteNonQuery();

                        comando.CommandText =
                             @"UPDATE PRODUTO SET Estoque = Estoque - @quantidade WHERE Id = @id";

                        comando.Parameters.AddWithValue("@id", p.ProdutoId);

                        comando.ExecuteNonQuery();     
                    }
                }

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "SELECT @@IDENTITY";

                    var result = (decimal)comando.ExecuteScalar();
                    var ultimoItemPedido = result;
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "DELETE ItemPedido WHERE PedidoId = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText = "DELETE Pedido WHERE id = @id";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Pedido> Listar()
        {
            var pedidos = new List<Pedido>();

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText =
                        "SELECT Id, NomeCliente FROM Pedido";

                    var dataReader = comando.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var pedido = new Pedido();

                        pedido.Id = (int)dataReader["Id"];
                        pedido.NomeCliente = (string)dataReader["NomeCliente"];

                        pedidos.Add(pedido);
                    }
                }
            }

            return pedidos;
        }

        public Pedido Obter(int id)
        {
            Pedido pedido = null;

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = conexao.CreateCommand())
                {
                    comando.CommandText =
                        "SELECT Id, NomeCliente FROM Pedido WHERE Id = @id";

                    comando.Parameters.AddWithValue("@id", id);

                    var dataReader = comando.ExecuteReader();
                    while (dataReader.Read())
                    {
                        pedido = new Pedido();
                        pedido.Id = (int)dataReader["Id"];
                        pedido.NomeCliente = (string)dataReader["NomeCliente"];
                        return pedido;
                    }
                }
            }

            return pedido;
        }
    }
}
