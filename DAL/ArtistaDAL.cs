using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ArtistaDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";
        public void InserirArtista(Artista objArtista)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Artistas VALUES (@nome, @dtNascimento, @pais ,@img)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objArtista.Nome);
            cmd.Parameters.AddWithValue("@dtNascimento", objArtista.DtNascimento);
            cmd.Parameters.AddWithValue("@pais", objArtista.PaisNascimento);
            cmd.Parameters.AddWithValue("@img", objArtista.Img_Artista);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void InserirArtistaFilme(ArtistaFilme objArtistaFilme)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Filmes_Artistas VALUES (@idfilme, @id, @personagem)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", objArtistaFilme.IdArtista);
            cmd.Parameters.AddWithValue("@idfilme", objArtistaFilme.IdFilme);
            cmd.Parameters.AddWithValue("@personagem", objArtistaFilme.Personagem);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void ExcluirArtista(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE * FROM Artistas WHERE Id_Artista = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizarArtista(Artista objArtista)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            
            conn.Open();

            string sql = "UPDATE Artistas SET Nome=@nome, Dt_Nascimento=@dtNascimento, Pais=@pais, Imagem=@img WHERE Id_Artista = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@c", objArtista.Codigo);
            cmd.Parameters.AddWithValue("@nome", objArtista.Nome);
            cmd.Parameters.AddWithValue("@dtNascimento", objArtista.DtNascimento);
            cmd.Parameters.AddWithValue("@pais", objArtista.PaisNascimento);
            cmd.Parameters.AddWithValue("@img", objArtista.Img_Artista);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Artista BuscarArtista(int codigo)
        {
            Artista p = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE Id_Artista = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                
                p = new Artista();
                p.Codigo = codigo;
                p.Nome = dr["Nome"].ToString();
                p.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimento"]);
                p.PaisNascimento = Convert.ToString(dr["Pais"]);
                p.Img_Artista = (byte[])dr["Img_Artista"];

                p.ListFilme = ListarFilmes(codigo);
            }

            conn.Close();
            
            return p;
        }


        public Artista BuscarArtistaNome(string codigo)
        {
            Artista p = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Artistas WHERE  Nome LIKE @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", $"%{codigo}%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                p = new Artista();
                p.Codigo = Convert.ToInt32( dr["Id_Artista"]);
                p.Nome = dr["Nome"].ToString();
                p.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimento"]);
                p.PaisNascimento = Convert.ToString(dr["Pais"]);
                p.Img_Artista = (byte[])dr["Img_Artista"];

                int cod = p.Codigo;

                p.ListFilme = ListarFilmes(cod);
            }

            conn.Close();

            return p;
        }

        public List<LArtista> ListarFilmes(int codigo)
        {

            List<LArtista> listaFilmes = new List<LArtista>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Filmes.*, Filmes_Artistas.Nm_Personagem FROM Filmes INNER JOIN Filmes_Artistas ON Filmes_Artistas.Id_Filme = Filmes.Id_Filme WHERE Filmes_Artistas.id_Artista = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                LArtista objFilme;

                while (dr.Read())
                {

                    objFilme = new LArtista();
                    objFilme.Id = Convert.ToInt32(dr["Id_Filme"]);
                    objFilme.Titulo = dr["Titulo"].ToString();
                    objFilme.NmPersonagem = dr["Nm_Personagem"].ToString();

                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }
    }
}
