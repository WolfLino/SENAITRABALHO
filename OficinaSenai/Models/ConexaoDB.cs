using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploBD.Models
{
    public class ConexaoDB
    {
        public MySqlConnection Conexao { get; set; }
        public MySqlCommand Comando { get; set; }

        public ConexaoDB()
        {
            string con = "Server=localhost;Database=oficina;" +
                "Uid=root;Pwd=venus;SslMode=none";
            Conexao = new MySqlConnection(con);
            Comando = Conexao.CreateCommand();
            Conexao.Open();
        }
    }
}