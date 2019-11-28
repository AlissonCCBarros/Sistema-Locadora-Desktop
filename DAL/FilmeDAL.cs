using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class FilmeDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";
        public void InserirFilme(Filme objFilme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Filmes VALUES (@codigoDeBarras ,@titulo ,@ano ,@tipo ,@preco ,@dt_adquirido ,@custo ,@situacao ,@diretor ,@descricao ,@img)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigoDeBarras", objFilme.CodigoDeBarras);
            cmd.Parameters.AddWithValue("@titulo", objFilme.Titulo);
            cmd.Parameters.AddWithValue("@ano", objFilme.Ano);
            cmd.Parameters.AddWithValue("@tipo", objFilme.Tipo);

            cmd.Parameters.AddWithValue("@preco", objFilme.Preco);
            cmd.Parameters.AddWithValue("@dt_adquirido", objFilme.DataAdiquirida);
            cmd.Parameters.AddWithValue("@custo", objFilme.ValorDeCusto);
            cmd.Parameters.AddWithValue("@situacao", objFilme.Situacao);
            cmd.Parameters.AddWithValue("@diretor", objFilme.Diretor);
            cmd.Parameters.AddWithValue("@descricao", objFilme.Descricao);
            cmd.Parameters.AddWithValue("@img", objFilme.Img_Filme);

            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public void InserirFilmeGenero(GeneroFilme objGeneroFilme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Filmes_Generos VALUES (@idfilme, @id)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", objGeneroFilme.IdGenero);
            cmd.Parameters.AddWithValue("@idfilme", objGeneroFilme.IdFilme);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void ExcluirFilme(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Filmes WHERE Id_Filme = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizarFilme(Filme objFilme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            
            conn.Open();

            string sql = "UPDATE Filmes SET Cod_Barras=@codigoDeBarras, Titulo=@titulo, Ano=@ano, Tipo=@tipo, Preco=@preco, Dt_Aquisicao=@dt_Aquisicao, Vl_Custo=@vl_custo, Situacao=@situacao, Diretor=@diretor, Descricao=@descricao,Imagem=@img WHERE Id_Filme = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);

            
            cmd.Parameters.AddWithValue("@codigoDeBarras", objFilme.CodigoDeBarras);
            cmd.Parameters.AddWithValue("@titulo", objFilme.Titulo);
            cmd.Parameters.AddWithValue("@ano", objFilme.Ano);
            cmd.Parameters.AddWithValue("@tipo", objFilme.Tipo);
            cmd.Parameters.AddWithValue("@preco", objFilme.Preco);
            cmd.Parameters.AddWithValue("@dt_Aquisicao", objFilme.DataAdiquirida);
            cmd.Parameters.AddWithValue("@vl_custo", objFilme.ValorDeCusto);
            cmd.Parameters.AddWithValue("@situacao", objFilme.Situacao);
            cmd.Parameters.AddWithValue("@diretor", objFilme.Diretor);
            cmd.Parameters.AddWithValue("@descricao", objFilme.Descricao);
            cmd.Parameters.AddWithValue("@img", objFilme.Img_Filme);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Filme PesquisarFilmes(int codigo)
        {
            Filme objFilme = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Filmes WHERE Id_Filme = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows && dr.Read())
            {
                objFilme = new Filme();
                objFilme.Codigo = codigo;
                objFilme.Titulo = dr["Titulo"].ToString();
                objFilme.CodigoDeBarras = dr["Cod_Barras"].ToString();
                objFilme.Ano = Convert.ToInt32(dr["Ano"]);
                objFilme.Tipo = dr["Tipo"].ToString();
                objFilme.Preco = Convert.ToDecimal(dr["Preco"]);
                objFilme.DataAdiquirida = Convert.ToDateTime(dr["Dt_Aquisicao"]);
                objFilme.ValorDeCusto = Convert.ToDecimal(dr["Vl_Custo"]);
                objFilme.Diretor = dr["Diretor"].ToString();
                objFilme.Descricao = dr["Descricao"].ToString();
                objFilme.Situacao = Convert.ToString(dr["Situacao"]);

                objFilme.ListFilmesGen = ListarFilmesGen(codigo);
                objFilme.ListFilmeCli = ListarFilmeCli(codigo);


            }

            conn.Close();

            return objFilme;
        }

        public List<Filme> ListarFilmes()
        {

            List<Filme> listaFilmes = new List<Filme>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Filmes WHERE Situacao = 0 ORDER BY Titulo ASC";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                Filme objFilme;

                while (dr.Read())
                {

                    objFilme = new Filme();
                    objFilme.Codigo = Convert.ToInt32(dr["Id_Filme"]);
                    objFilme.CodigoDeBarras = Convert.ToString(dr["Cod_Barras"]);
                    objFilme.Titulo = Convert.ToString(dr["Titulo"]);
                    objFilme.Ano = Convert.ToInt32(dr["Ano"]);
                    objFilme.Tipo = Convert.ToString(dr["Tipo"]);
                    objFilme.Preco = Convert.ToDecimal(dr["Preco"]);
                    objFilme.DataAdiquirida = Convert.ToDateTime(dr["Dt_Aquisicao"]);
                    objFilme.ValorDeCusto = Convert.ToDecimal(dr["Vl_Custo"]);
                    objFilme.Situacao = (dr["Situacao"]).ToString();
                    objFilme.Diretor = Convert.ToString(dr["Diretor"]);
                    objFilme.Descricao = Convert.ToString(dr["Descricao"]);
                    objFilme.Img_Filme = (byte[])dr["Img_Filme"];

                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }

        public List<TopFilmes> ListarFilmesTop()
        {

            List<TopFilmes> listaFilmes = new List<TopFilmes>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT TOP 10 Clientes.Nome, Locacoes.Dt_Atual, Locacoes.Dt_Prevista, Locacoes.Dt_Devolucao, Locacoes.Vl_Pago" +
                "  FROM Locacoes INNER JOIN Clientes ON Clientes.Id_Cliente = Locacoes.Id_Cliente";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                TopFilmes objFilme;

                while (dr.Read())
                {

                    objFilme = new TopFilmes();

                    if (dr["Dt_Devolucao"] != DBNull.Value)
                    {
                        objFilme.Nome = dr["Nome"].ToString();
                        objFilme.Dt_Atual = Convert.ToDateTime(dr["Dt_Atual"]);
                        objFilme.Dt_Prev = Convert.ToDateTime(dr["Dt_Prevista"]);
                        objFilme.Dt_Devolucao = Convert.ToDateTime(dr["Dt_Devolucao"]);
                        objFilme.Vl_Pago = Convert.ToDecimal(dr["Vl_Pago"]);
                    }
                    else
                    {
                        objFilme.Nome = dr["Nome"].ToString();
                        objFilme.Dt_Atual = Convert.ToDateTime(dr["Dt_Atual"]);
                        objFilme.Dt_Prev = Convert.ToDateTime(dr["Dt_Prevista"]);
                        //objFilme.Dt_Devolucao = Convert.ToDateTime(dr["Dt_Devolucao"]);
                        //objFilme.Vl_Pago = Convert.ToDecimal(dr["Vl_Pago"]);
                    }


                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }

        public List<SelecFilme> ListarFilmesGen(int codigo)
        {

            List<SelecFilme> listaFilmes = new List<SelecFilme>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Filmes.Cod_Barras, Filmes.Titulo, g.Nome, Filmes.Ano FROM Generos g INNER JOIN Filmes_Generos f ON f.Id_Genero = g.Id_genero INNER JOIN Filmes ON Filmes.Id_Filme = f.Id_Filme WHERE f.Id_Filme = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                SelecFilme objFilme;

                while (dr.Read())
                {

                    objFilme = new SelecFilme();
                    objFilme.CodBarras = dr["Cod_Barras"].ToString();
                    objFilme.Titulo = dr["Titulo"].ToString();
                    objFilme.Genero = dr["Nome"].ToString();
                    objFilme.Ano = Convert.ToInt32(dr["Ano"]);

                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }

        public List<FilmeCli> ListarFilmeCli(int codigo)
        {

            List<FilmeCli> listaFilmes = new List<FilmeCli>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT C.Nome, L.Dt_Atual, L.Dt_Prevista, C.Telefone, C.Celular FROM Locacoes L" +
                " INNER JOIN Clientes C ON C.Id_Cliente = L.Id_Cliente INNER JOIN Detalhe_Locacao DL ON DL.Id_Locacao = L.Id_Locacao WHERE DL.Id_Filme = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                FilmeCli objFimleCliente;

                while (dr.Read())
                {
                    objFimleCliente = new FilmeCli();

                    if(dr["Telefone"] != DBNull.Value)
                    {
                        objFimleCliente.Nome = dr["Nome"].ToString();
                        objFimleCliente.DtLocacao = Convert.ToDateTime(dr["Dt_Atual"]);
                        objFimleCliente.DtLocacao = Convert.ToDateTime(dr["Dt_Prevista"]);
                        objFimleCliente.Telefone = dr["Telefone"].ToString();
                        objFimleCliente.Celular = dr["Celular"].ToString();
                        
                    }
                    else
                    {
                        objFimleCliente.Nome = dr["Nome"].ToString();
                        objFimleCliente.DtLocacao = Convert.ToDateTime(dr["Dt_Atual"]);
                        objFimleCliente.DtLocacao = Convert.ToDateTime(dr["Dt_Prevista"]);
                        //objFimleCliente.Telefone = dr["Telefone"].ToString();
                        objFimleCliente.Celular = dr["Celular"].ToString();
                        
                    }

                    listaFilmes.Add(objFimleCliente);

                }
            }

            conn.Close();

            return listaFilmes;
        }

    }
}
