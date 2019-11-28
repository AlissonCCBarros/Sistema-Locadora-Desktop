using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class DevolucaoDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";

        public void InserirDevolucao(Locacao objLocacao)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "EXEC Inserir_Devolucao @idLocacao, @VlMulta, @DtDevolucao, @VlPago, @VlTotal, @TipoPag";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idLocacao", objLocacao.Id_Locacao);
            cmd.Parameters.AddWithValue("@VlMulta", objLocacao.Vl_Multa);
            cmd.Parameters.AddWithValue("@DtDevolucao", objLocacao.Dt_Devolucao);
            cmd.Parameters.AddWithValue("@VlPago", objLocacao.Vl_Pago);
            cmd.Parameters.AddWithValue("@VlTotal", objLocacao.Vl_Total);
            cmd.Parameters.AddWithValue("@TipoPag", objLocacao.Tipo_Pagamento);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void AtualizaStatus(int cod)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Clientes SET Status = 'Inativo' WHERE Id_Cliente = @id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", cod);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public Locacao Buscar(int codigo)
        {
            Locacao objLocacao = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT L.*, C.Nome, c.Cpf FROM Locacoes L INNER JOIN Clientes C ON C.Id_Cliente = L.Id_Cliente WHERE Id_Locacao = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.Id_Locacao = codigo;
                objLocacao.Id_Funcionario = Convert.ToInt32(dr["Id_Funcionario"]);
                objLocacao.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                objLocacao.NomeCli = dr["Nome"].ToString();
                objLocacao.CPF = dr["Cpf"].ToString();
                objLocacao.Dt_Atual = Convert.ToDateTime(dr["Dt_Atual"]);
                objLocacao.Dt_Prevista = Convert.ToDateTime(dr["Dt_Prevista"]);
                objLocacao.Vl_Pago = Convert.ToDecimal(dr["Vl_Pago"]);
                objLocacao.Vl_Total = Convert.ToDecimal(dr["Vl_Total"]);
                objLocacao.Vl_Debito = Convert.ToDecimal(dr["Vl_Debito"]);
                objLocacao.Tipo_Pagamento = dr["Tipo_Pagamento"].ToString();

            }

            conn.Close();

            return objLocacao;
        }

        public void ExcluirLocacao(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Locacoes WHERE Id_Locacao = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizarLocacao(Locacao objLocacao)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Locacoes SET Id_Funcionario=@idfunc, Id_Cliente=@idCli, Dt_Atual=@dtatual, Dt_Prevista=@dtprev, Vl_Pago=@vlpago, Vl_Total=@vltotal, Vl_Debito=@vldeb, Tipo_Pagamento=@tipo  WHERE Id_Locacao = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@c", objLocacao.Id_Locacao);
            cmd.Parameters.AddWithValue("@idfunc", objLocacao.Id_Funcionario);
            cmd.Parameters.AddWithValue("@idCli", objLocacao.Id_Cliente);
            cmd.Parameters.AddWithValue("@dtatual", objLocacao.Dt_Atual);
            cmd.Parameters.AddWithValue("@dtprev", objLocacao.Dt_Prevista);
            cmd.Parameters.AddWithValue("@vlpago", objLocacao.Vl_Pago);
            cmd.Parameters.AddWithValue("@vltotal", objLocacao.Vl_Total);
            cmd.Parameters.AddWithValue("@vldeb", objLocacao.Vl_Debito);
            cmd.Parameters.AddWithValue("@tipo", objLocacao.Tipo_Pagamento);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Locacao BuscarLocacao(int codigo)
        {
            Locacao objLocacao = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Locacoes WHERE Id_Locacao = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.Id_Locacao = codigo;
                objLocacao.ListLocacao = ListarFilmes(codigo);
                objLocacao.Vl_Debito = Convert.ToDecimal(dr["Vl_Debito"]);
                objLocacao.Vl_Total = Convert.ToDecimal(dr["Vl_Total"]);
                objLocacao.Vl_Pago = Convert.ToDecimal(dr["Vl_Pago"]);
                objLocacao.Tipo_Pagamento = Convert.ToString(dr["Tipo_Pagamento"]);
            }

            conn.Close();

            return objLocacao;
        }

        public Locacao BuscarDias(int codigo)
        {
            Locacao objLocacao = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT  Distinct CASE WHEN Locacoes.Dt_Prevista < GETDATE() THEN DATEDIFF(DAY, Locacoes.Dt_Prevista, GETDATE())END AS DiasAtraso" +
                " FROM Detalhe_Locacao INNER JOIN Locacoes ON Detalhe_Locacao.Id_Locacao = Locacoes.Id_Locacao" +
                " INNER JOIN Filmes ON Filmes.Id_Filme = Detalhe_Locacao.Id_Filme WHERE Locacoes.Dt_Devolucao IS NULL AND Locacoes.Id_Locacao = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                
                if(dr["DiasAtraso"] != DBNull.Value)
                {
                    objLocacao.Id_Locacao = codigo;
                    objLocacao.DiasAtraso = Convert.ToInt32(dr["DiasAtraso"]);
                }
                else
                {
                    objLocacao.Id_Locacao = codigo;
                }

            }

            conn.Close();

            return objLocacao;
        }

        public Locacao BuscarQntdFilmes(int codigo)
        {
            Locacao objLocacao = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT COUNT(Id_Locacao) AS Qntd FROM Detalhe_Locacao WHERE Id_Locacao = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.Id_Locacao = codigo;
                objLocacao.Itens = Convert.ToInt32(dr["Qntd"]);

            }

            conn.Close();

            return objLocacao;
        }

        public List<LocacaoDevolucao> ListarFilmes(int codigo)
        {

            List<LocacaoDevolucao> listaFilmes = new List<LocacaoDevolucao>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT F.Id_Filme, F.Cod_Barras, F.Titulo FROM Detalhe_Locacao D INNER JOIN Filmes F ON F.Id_Filme = D.Id_Filme WHERE D.Id_Locacao = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                LocacaoDevolucao objFilme;

                while (dr.Read())
                {

                    objFilme = new LocacaoDevolucao();
                    objFilme.Id_Filme = Convert.ToInt32(dr["Id_Filme"]);
                    objFilme.codBarras = dr["Cod_Barras"].ToString();
                    objFilme.Titulo = dr["Titulo"].ToString();

                    listaFilmes.Add(objFilme);

                }
            }

            conn.Close();

            return listaFilmes;
        }

        public Locacao BuscarFilmeCodBarras(string codigo)
        {

            Locacao objLocacao = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Id_Filme FROM Filmes WHERE Cod_Barras = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.Id_Filme = Convert.ToInt32(dr["Id_Filme"]);

            }

            conn.Close();

            return objLocacao;
        }

        public void DevolverFilme(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Filmes SET Situacao=0 WHERE Id_Filme = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);


            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
