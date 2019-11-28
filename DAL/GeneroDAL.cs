using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class GeneroDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";
        public void InseriGenero(Genero objGenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Generos VALUES (@nome)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objGenero.Nome);
            

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ExcluirGenero(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Generos WHERE Id_Genero = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizarGenero(Genero objGenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE Generos SET Nome=@nome WHERE Id_Genero = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objGenero.Nome);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Genero BuscarGenero(int codigo)
        {
            Genero objGenero = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Generos WHERE Id_Genero = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objGenero = new Genero();
                objGenero.Codigo = codigo;
                objGenero.Nome = dr["Nome"].ToString();

            }

            conn.Close();

            return objGenero;
        }

        public List<Genero> ListarGeneros()
        {
            List<Genero> ListaGenero = new List<Genero>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Generos";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Genero objGenero;

                while (dr.Read())
                {
                    objGenero = new Genero();
                    objGenero.Codigo = Convert.ToInt32(dr["Id_genero"]);
                    objGenero.Nome = dr["Nome"].ToString();

                    ListaGenero.Add(objGenero);
                }
            }

            conn.Close();

            return ListaGenero;
        }
    }
}
