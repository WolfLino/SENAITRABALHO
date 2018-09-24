using System;

namespace ExemploBD.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public int PrazoEntrega { get; set; }
        public double Total { get; set; }
        public char Status { get; set; }
    }
}