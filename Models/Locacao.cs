using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Locacao
    {
        public int Id_Locacao { get; set; }
        public int Id_Funcionario { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Dt_Prevista { get; set; }
        public DateTime Dt_Atual { get; set; }       
        public string Tipo_Pagamento { get; set; }
        public decimal Vl_Total { get; set; }
        public decimal Vl_Pago { get; set; }
        public decimal Vl_Debito { get; set; }
        public decimal Vl_Multa { get; set; }

        public DateTime Dt_Devolucao { get; set; }
        public string NomeCli { get; set; }
        public string CPF { get; set; }
        

        public int Id_Detalhe { get; set; }
        public int Id_Filme { get; set; }
        public int DiasAtraso { get; set; }
        public int Itens { get; set; }

        public ICollection<LocacaoDevolucao> ListLocacao { get; set; }
        
    }
}
