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
    }
}