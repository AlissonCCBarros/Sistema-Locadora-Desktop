using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class LocacaoDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";

        public void InserirLocacao(Locacao objLocacao)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Locacoes(Id_Funcionario, Id_Cliente, Dt_Prevista, Dt_Atual) VALUES (@idFun, @idCli, @dtprev, @dtatual)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idFun", objLocacao.Id_Funcionario);
            cmd.Parameters.AddWithValue("@idCli", objLocacao.Id_Cliente);
            cmd.Parameters.AddWithValue("@dtprev", objLocacao.Dt_Prevista);
            cmd.Parameters.AddWithValue("@dtatual", objLocacao.Dt_Atual);
                        
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void FecharLocacao(Locacao objLocacao)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE Locacoes SET Vl_Total=@vltotal, Vl_Pago=@vlpago, Tipo_Pagamento=@tipo, Vl_Debito=@vldeb WHERE Id_Locacao = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objLocacao.Id_Locacao);
            cmd.Parameters.AddWithValue("@vltotal", objLocacao.Vl_Total);
            cmd.Parameters.AddWithValue("@vlpago", objLocacao.Vl_Pago);
            cmd.Parameters.AddWithValue("@tipo", objLocacao.Tipo_Pagamento);
            cmd.Parameters.AddWithValue("@vldeb", objLocacao.Vl_Debito);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void InserirDetalhes(Locacao objLocacao)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Detalhe_Locacao VALUES (@idLocacao, @idFilme)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@idLocacao", objLocacao.Id_Locacao);
            cmd.Parameters.AddWithValue("@idFilme", objLocacao.Id_Filme);


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

        public Locacao BuscarLocacao()
        {
            Locacao objLocacao = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Id_Locacao FROM Locacoes WHERE Id_Locacao = (SELECT MAX(Id_Locacao) FROM Locacoes) ";

            SqlCommand cmd = new SqlCommand(sql, conn);
            

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objLocacao = new Locacao();
                objLocacao.Id_Locacao = Convert.ToInt32(dr["Id_Locacao"]);

            }

            conn.Close();

            return objLocacao;
        }
    }
}
