using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ExemploBD.Models.DAO
{
    public class OrdemServicoDAO
    {
        private ConexaoDB con;

        public OrdemServicoDAO()
        {
            con = new ConexaoDB();
        }

        /// <summary>
        /// Obtém uma todas as ordens de serviços do cliente.
        /// </summary>
        /// <param name="c">Cliente em buscado.</param>
        /// <returns>DataTable com todas as ordens de serviços do cliente.</returns>
        public DataTable BuscarPorCliente(Cliente c)
        {
            return BuscarPorCliente(c.Id);
        }

        /// <summary>
        /// Obtém uma todas as ordens de serviços do cliente.
        /// </summary>
        /// <param name="id">Id do cliente buscado.</param>
        /// <returns>DataTable com todas as ordens de serviços do cliente.</returns>
        public DataTable BuscarPorCliente(int id)
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ordem_serv WHERE cliente_idcliente = " + id, con.Conexao);

                adapter.Fill(table);

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

        public void Alterar(OrdemServico oS)
        {
            try
            {
                string sql = "UPDATE ordem_serv SET status = @status WHERE idordem_serv = @id";

                con.Comando.CommandText = sql;
                con.Comando.Parameters.AddWithValue("@status", oS.Status);
                con.Comando.Parameters.AddWithValue("@id", oS.Id);

                int returno = con.Comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return;
            }
            finally
            {
                con.Conexao.Close();
            }
        }
    }
}