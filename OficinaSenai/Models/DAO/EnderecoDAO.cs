using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExemploBD.Models.DAO
{
    public class EnderecoDAO
    {
        private ConexaoDB con;
        public EnderecoDAO()
        {
            con = new ConexaoDB();
        }
        public Endereco Inserir(Endereco e)
        {
            try
            {
                String sql = "Insert into endereco(rua, bairro, cep, comp, numero, cliente_idcliente)" +
                    "values(@rua, @bairro, @cep, @complemento, @numero,  @idcliente)";
                con.Comando.CommandText = sql;
                con.Comando.Parameters.AddWithValue("@rua", e.Rua);
                con.Comando.Parameters.AddWithValue("@bairro", e.Bairro);
                con.Comando.Parameters.AddWithValue("@cep", e.Cep);
                con.Comando.Parameters.AddWithValue("@complemento", e.Complemento);
                con.Comando.Parameters.AddWithValue("@numero", e.Numero);
                con.Comando.Parameters.AddWithValue("@idcliente", e.IdCliente);
                int retorno = con.Comando.ExecuteNonQuery();

                if (retorno > 0)
                {
                    e.Id = Convert.ToInt32(con.Comando.LastInsertedId.ToString());
                    return e;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Conexao.Close();
            }
        }

        public DataTable ListarTodos(Cliente a)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter sqlData;

                sqlData = new MySqlDataAdapter("Select * from endereco where cliente_idcliente = @id", con.Conexao);
                sqlData.SelectCommand.Parameters.AddWithValue("@id", a.Id);

                sqlData.Fill(table);
                return table;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                con.Conexao.Close();
            }

        }


        public Endereco Alterar(Endereco e)
        {
            try
            {
                string sql = "UPDATE endereco set rua = @rua," +
                    "bairro = @bairro, cep = @cep, comp = @complemento," +
                    "numero = @numero where idEndereco = @idendereco";
                con.Comando.CommandText = sql;
                con.Comando.Parameters.AddWithValue("@rua", e.Rua);
                con.Comando.Parameters.AddWithValue("@bairro", e.Bairro);
                con.Comando.Parameters.AddWithValue("@cep", e.Cep);
                con.Comando.Parameters.AddWithValue("@complemento", e.Complemento);
                con.Comando.Parameters.AddWithValue("@numero", e.Numero);
                con.Comando.Parameters.AddWithValue("@idEndereco", e.Id);
                int retorno = con.Comando.ExecuteNonQuery();
                return retorno > 0 ? e : null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Conexao.Close();
            }
        }


        public Endereco Deletar(Endereco c)
        {
            try
            {
                con.Comando.CommandText = "DELETE FROM endereco where idEndereco = @idendereco";
                con.Comando.Parameters.AddWithValue("idEndereco", c.Id);
                int retorno = con.Comando.ExecuteNonQuery();
                return retorno > 0 ? c : null;
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                con.Conexao.Close();
            }
        }
    }
}