using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploBD.Models.DAO
{
    public class LoginDAO
    {
        private ConexaoDB con;
        public LoginDAO()
        {
            con = new ConexaoDB();
        }

        public Cliente Logar(Cliente cliente)
        {
            try
            {
                
                string comando = "Select * from cliente where email = @email and senha = @senha";
                con.Comando.CommandText = comando;
                con.Comando.Parameters.AddWithValue("@email", cliente.Email);
                con.Comando.Parameters.AddWithValue("@senha", cliente.Senha);
                MySqlDataReader reader = con.Comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    Cliente c = new Cliente()
                    {
                        Nome = reader["nome"].ToString(),
                        Id = Convert.ToInt32(reader["idcliente"]),
                        Cpf = reader["cpf"].ToString(),
                        Rg = reader["rg"].ToString(),
                        Email = reader["email"].ToString(),
                        Senha = reader["senha"].ToString()
                    };
                    return c;
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
        }

    }
}