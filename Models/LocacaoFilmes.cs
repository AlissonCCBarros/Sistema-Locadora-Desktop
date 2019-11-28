using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LocacaoFilmes
    {
        public string NomeCli { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public DateTime Dt_Prev { get; set; }
        public int DiasAtraso { get; set; }
    }
}
