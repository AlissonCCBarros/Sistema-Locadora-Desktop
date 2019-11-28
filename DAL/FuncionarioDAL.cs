using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class FuncionarioDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";

        public void InserirFuncionario(Funcionario objFuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Funcionarios VALUES (@nome, @dtNascimento ,@sexo ,@EstadoCivil ,@RG ,@Cpf ,@endereco ,@CEP ,@cidade ,@estado, @telefone, @celular, @email, @status)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            
            cmd.Parameters.AddWithValue("@nome", objFuncionario.Nome);
            cmd.Parameters.AddWithValue("@dtNascimento", objFuncionario.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objFuncionario.Sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", objFuncionario.EstadoCivil);
            cmd.Parameters.AddWithValue("@RG", objFuncionario.RG);
            cmd.Parameters.AddWithValue("@Cpf", objFuncionario.CPF);
            cmd.Parameters.AddWithValue("@endereco", objFuncionario.Endereco);
            cmd.Parameters.AddWithValue("@CEP", objFuncionario.CEP);
            cmd.Parameters.AddWithValue("@cidade", objFuncionario.Cidade);
            cmd.Parameters.AddWithValue("@estado", objFuncionario.Estado);
            cmd.Parameters.AddWithValue("@telefone", objFuncionario.Telefone);
            cmd.Parameters.AddWithValue("@celular", objFuncionario.Celular);
            cmd.Parameters.AddWithValue("@email", objFuncionario.Email);
            cmd.Parameters.AddWithValue("status", objFuncionario.Status);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ExcluirFuncionario(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Funcionarios WHERE Id_Funcionario = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<CliBusca> ListarFuncionarios()
        {
            List<CliBusca> ListaFuncionarios = new List<CliBusca>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Funcionarios";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                CliBusca objCliBusca;

                while (dr.Read())
                {
                    objCliBusca = new CliBusca();
                    objCliBusca.Codigo = Convert.ToInt32(dr["Id_Funcionario"]);
                    objCliBusca.Nome = dr["Nome"].ToString();
                    objCliBusca.CPF = dr["Cpf"].ToString();
                    objCliBusca.Status = dr["Status"].ToString();

                    ListaFuncionarios.Add(objCliBusca);
                }
            }

            conn.Close();

            return ListaFuncionarios;
        }


        public Funcionario BuscarFuncionario(int codigo)
        {

            Funcionario objFuncionario = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Funcionarios WHERE Id_Funcionario = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);


            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows && dr.Read())
            {
                objFuncionario = new Funcionario();
                objFuncionario.Codigo = Convert.ToInt32(dr["Id_Funcionario"]);
                objFuncionario.Nome = dr["Nome"].ToString();
                objFuncionario.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimaneto"]);
                objFuncionario.Sexo = dr["Sexo"].ToString();
                objFuncionario.EstadoCivil = dr["Estado_Civil"].ToString();
                objFuncionario.RG = dr["Rg"].ToString();
                objFuncionario.CPF = dr["Cpf"].ToString();
                objFuncionario.Endereco = dr["Endereco"].ToString();
                objFuncionario.CEP = Convert.ToString(dr["Cep"]);
                objFuncionario.Cidade = dr["Cidade"].ToString();
                objFuncionario.Estado = dr["Estado"].ToString();
                objFuncionario.Telefone = dr["Telefone"].ToString();
                objFuncionario.Celular = dr["Celular"].ToString();
                objFuncionario.Email = dr["Email"].ToString();
                objFuncionario.Status = dr["Status"].ToString();

                objFuncionario.ListFilmes = ListarFilmes(codigo);

            }

            conn.Close();
            
            return objFuncionario;
        }

        public Funcionario BuscarFuncionarioCPF(string cpf)
        {

            Funcionario objFuncionario = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Funcionarios WHERE Cpf = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", cpf);


            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows && dr.Read())
            {
                objFuncionario = new Funcionario();
                objFuncionario.Codigo = Convert.ToInt32(dr["Id_Funcionario"]);
                objFuncionario.Nome = dr["Nome"].ToString();
                objFuncionario.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimaneto"]);
                objFuncionario.Sexo = dr["Sexo"].ToString();
                objFuncionario.EstadoCivil = dr["Estado_Civil"].ToString();
                objFuncionario.RG = dr["Rg"].ToString();
                objFuncionario.CPF = dr["Cpf"].ToString();
                objFuncionario.Endereco = dr["Endereco"].ToString();
                objFuncionario.CEP = Convert.ToString(dr["Cep"]);
                objFuncionario.Cidade = dr["Cidade"].ToString();
                objFuncionario.Estado = dr["Estado"].ToString();
                objFuncionario.Telefone = dr["Telefone"].ToString();
                objFuncionario.Celular = dr["Celular"].ToString();
                objFuncionario.Email = dr["Email"].ToString();
                objFuncionario.Status = dr["Status"].ToString();

            }

            conn.Close();
  
            return objFuncionario;
        }


        public void AtualizarFuncionario(Funcionario objFuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE Funcionarios SET Nome=@nome, Dt_Nascimaneto=@dtNascimento, Sexo=@sexo, Estado_Civil=@estadoCivil, Rg=@rg, Cpf=@cpf, Endereco=@endereco, Cep=@cep, Cidade=@cidade, Estado=@estado, Telefone=@telefone, Celular=@celular, Email=@email, Status=@status WHERE Id_Funcionario = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", objFuncionario.Codigo);
            cmd.Parameters.AddWithValue("@nome", objFuncionario.Nome);
            cmd.Parameters.AddWithValue("@dtNascimento", objFuncionario.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objFuncionario.Sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", objFuncionario.EstadoCivil);
            cmd.Parameters.AddWithValue("@RG", objFuncionario.RG);
            cmd.Parameters.AddWithValue("@Cpf", objFuncionario.CPF);
            cmd.Parameters.AddWithValue("@endereco", objFuncionario.Endereco);
            cmd.Parameters.AddWithValue("@CEP", objFuncionario.CEP);
            cmd.Parameters.AddWithValue("@cidade", objFuncionario.Cidade);
            cmd.Parameters.AddWithValue("@estado", objFuncionario.Estado);
            cmd.Parameters.AddWithValue("@telefone", objFuncionario.Telefone);
            cmd.Parameters.AddWithValue("@celular", objFuncionario.Celular);
            cmd.Parameters.AddWithValue("@email", objFuncionario.Email);
            cmd.Parameters.AddWithValue("status", objFuncionario.Status);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<LocacaoFilmes> ListarFilmes(int codigo)
        {

            List<LocacaoFilmes> listaLocacao = new List<LocacaoFilmes>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Clientes.Nome, Filmes.Titulo, Filmes.Preco, Locacoes.Dt_Prevista," +
                " CASE WHEN Locacoes.Dt_Prevista < GETDATE() THEN DATEDIFF (DAY, Locacoes.Dt_Prevista, GETDATE()) END AS DiasAtraso" +
                " FROM Locacoes INNER JOIN Clientes ON Clientes.Id_Cliente = Locacoes.Id_Cliente" +
                " INNER JOIN Detalhe_Locacao ON Detalhe_Locacao.Id_Locacao = Locacoes.Id_Locacao" +
                " INNER JOIN Filmes ON Filmes.Id_Filme = Detalhe_Locacao.Id_Filme WHERE Locacoes.Dt_Devolucao IS NULL AND Locacoes.Id_Funcionario = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                LocacaoFilmes objLocacao;

                while (dr.Read())
                {

                    objLocacao = new LocacaoFilmes();

                    if (dr["DiasAtraso"] != DBNull.Value)
                    {
                        objLocacao.NomeCli = dr["Nome"].ToString();
                        objLocacao.Titulo = dr["Titulo"].ToString();
                        objLocacao.Preco = Convert.ToDecimal(dr["Preco"]);
                        objLocacao.Dt_Prev = Convert.ToDateTime(dr["Dt_Prevista"]);
                        objLocacao.DiasAtraso = Convert.ToUInt16(dr["DiasAtraso"]);
                    }
                    else
                    {
                        objLocacao.NomeCli = dr["Nome"].ToString();
                        objLocacao.Titulo = dr["Titulo"].ToString();
                        objLocacao.Preco = Convert.ToDecimal(dr["Preco"]);
                        objLocacao.Dt_Prev = Convert.ToDateTime(dr["Dt_Prevista"]);
                        objLocacao.DiasAtraso = 0;
                    }

                    listaLocacao.Add(objLocacao);

                }
            }

            conn.Close();

            return listaLocacao;
        }

    }

}
