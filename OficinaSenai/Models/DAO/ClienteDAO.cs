using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ExemploBD.Models.DAO
{
    public class ClienteDAO
    {
        private ConexaoDB con;
        public ClienteDAO()
        {
            con = new ConexaoDB();
        }
        public DataTable ListarTodos(string nome)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter sqlData;
                if (string.IsNullOrEmpty(nome))
                {
                    sqlData =
                    new MySqlDataAdapter("SELECT * FROM cliente",
                    con.Conexao);
                }
                else
                {
                    sqlData =
                    new MySqlDataAdapter("SELECT * FROM cliente WHERE " +
                    "nome like '%" + nome + "%'",
                    con.Conexao);

                }

                sqlData.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Conexao.Close();
            }
        }
        public Cliente BuscarPorId(int id)
        {
            try
            {
                string comando = "SELECT * FROM cliente " +
                    "WHERE idcliente = @id";
                con.Comando.CommandText = comando;
                con.Comando.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = con.Comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Cliente c = new Cliente()
                    {
                        Nome = reader["nome"].ToString(),
                        Id = Convert.ToInt32(reader["id"]),
                        Cpf = reader["cpf"].ToString(),
                        Rg = reader["rg"].ToString()
                    };
                    return c;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Conexao.Close();
            }
        }
        public Cliente Inserir(Cliente c)
        {
            try
            {
                string sql = "INSERT INTO cliente(nome, cpf, rg) VALUES" +
                    "(@nome, @cpf, @rg);";
                con.Comando.CommandText = sql;
                con.Comando.Parameters.AddWithValue("@nome", c.Nome);
                con.Comando.Parameters.AddWithValue("@cpf", c.Cpf);
                con.Comando.Parameters.AddWithValue("@rg", c.Rg);
                int retorno = con.Comando.ExecuteNonQuery();
                if (retorno > 0)
                {
                    c.Id = Convert.ToInt32(con.Comando.LastInsertedId.ToString());
                    return c;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Conexao.Close();
            }
        }
        public Cliente Alterar(Cliente c)
        {
            try
            {
                string sql = "UPDATE cliente SET nome = @nome," +
                    "cpf = @cpf, rg = @rg WHERE idcliente = @id";
                con.Comando.CommandText = sql;
                con.Comando.Parameters.AddWithValue("@nome", c.Nome);
                con.Comando.Parameters.AddWithValue("@cpf", c.Cpf);
                con.Comando.Parameters.AddWithValue("@rg", c.Rg);
                con.Comando.Parameters.AddWithValue("@id", c.Id);
                int returno = con.Comando.ExecuteNonQuery();
                return returno > 0 ? c : null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                con.Conexao.Close();
            }
        }
        public Cliente Deletar(Cliente c)
        {
            try
            {
                con.Comando.CommandText = "DELETE FROM cliente " +
                    "WHERE idcliente = @id;";
                con.Comando.Parameters.AddWithValue("@id", c.Id);
                int retorno = con.Comando.ExecuteNonQuery();
                return retorno > 0 ? c : null;
            }
            catch (Exception e)
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