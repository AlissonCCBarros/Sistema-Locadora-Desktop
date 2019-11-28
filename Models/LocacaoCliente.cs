using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LocacaoCliente
    {
        public string NomeCli { get; set; }
        public DateTime Dt_Atual { get; set; }
        public DateTime Dt_Devolucao { get; set; }
        public DateTime Dt_Prevista { get; set; }
        public decimal Vl_Pago { get; set; }
    }
}
