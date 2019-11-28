using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Filme
    {
        public int Codigo { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Titulo { get; set; }      
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataAdiquirida { get; set; }
        public decimal ValorDeCusto { get; set; }
        public string Situacao { get; set; }
        public string Atores { get; set; }
        public string Diretor { get; set; }
        public string Descricao { get; set; }
        public byte[] Img_Filme { get; set; }

        public ICollection<SelecFilme> ListFilmesGen { get; set; }
        public ICollection<FilmeCli> ListFilmeCli { get; set; }

    }
}
