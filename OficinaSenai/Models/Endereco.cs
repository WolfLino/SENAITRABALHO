using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploBD.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public String Complemento { get; set; }
        public String Numero { get; set; }
        public int IdCliente { get; set; }

    }
}