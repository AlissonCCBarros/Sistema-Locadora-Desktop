using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDAL
    {
        string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";
        public void InserirCliente(Cliente objCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Clientes VALUES (@nome, @dtNascimento ,@sexo ,@EstadoCivil ,@RG ,@Cpf ,@endereco ,@CEP ,@cidade ,@estado, @telefone, @celular, @email, @status)";
            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.Parameters.AddWithValue("@nome", objCliente.Nome);
            cmd.Parameters.AddWithValue("@dtNascimento", objCliente.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objCliente.Sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", objCliente.EstadoCivil);
            cmd.Parameters.AddWithValue("@RG", objCliente.RG);
            cmd.Parameters.AddWithValue("@Cpf", objCliente.CPF);
            cmd.Parameters.AddWithValue("@endereco", objCliente.Endereco);
            cmd.Parameters.AddWithValue("@CEP", objCliente.CEP);
            cmd.Parameters.AddWithValue("@cidade", objCliente.Cidade);
            cmd.Parameters.AddWithValue("@estado", objCliente.Estado);
            cmd.Parameters.AddWithValue("@telefone", objCliente.Telefone);
            cmd.Parameters.AddWithValue("@celular", objCliente.Celular);
            cmd.Parameters.AddWithValue("@email", objCliente.Email);
            cmd.Parameters.AddWithValue("status", objCliente.Status);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ExcluirCliente(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Clientes WHERE Id_Cliente = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void AtualizarCliente(Cliente objCliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE Clientes SET Nome=@nome, Dt_Nascimaneto=@dtNascimento, Sexo=@sexo, Estado_Civil=@estadoCivil, Rg=@rg, Cpf=@cpf, Endereco=@endereco, Cep=@cep, Cidade=@cidade, Estado=@estado, Telefone=@telefone, Celular=@celular, Email=@email, Status=@status WHERE Id_Cliente = @cod";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cod", objCliente.Codigo);
            cmd.Parameters.AddWithValue("@nome", objCliente.Nome);
            cmd.Parameters.AddWithValue("@dtNascimento", objCliente.DtNascimento);
            cmd.Parameters.AddWithValue("@sexo", objCliente.Sexo);
            cmd.Parameters.AddWithValue("@EstadoCivil", objCliente.EstadoCivil);
            cmd.Parameters.AddWithValue("@RG", objCliente.RG);
            cmd.Parameters.AddWithValue("@Cpf", objCliente.CPF);
            cmd.Parameters.AddWithValue("@endereco", objCliente.Endereco);
            cmd.Parameters.AddWithValue("@CEP", objCliente.CEP);
            cmd.Parameters.AddWithValue("@cidade", objCliente.Cidade);
            cmd.Parameters.AddWithValue("@estado", objCliente.Estado);
            cmd.Parameters.AddWithValue("@telefone", objCliente.Telefone);
            cmd.Parameters.AddWithValue("@celular", objCliente.Celular);
            cmd.Parameters.AddWithValue("@email", objCliente.Email);
            cmd.Parameters.AddWithValue("status", objCliente.Status);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        
        public Cliente BuscarCliente(int codigo)
        {

            Cliente objCliente = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Clientes WHERE Id_Cliente = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", codigo);


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {

                objCliente = new Cliente();
                objCliente.Codigo = Convert.ToInt32(dr["Id_Cliente"]);
                objCliente.Nome = dr["Nome"].ToString();
                objCliente.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimaneto"]);
                objCliente.Sexo = dr["Sexo"].ToString();
                objCliente.EstadoCivil = dr["Estado_Civil"].ToString();
                objCliente.RG = dr["Rg"].ToString();
                objCliente.CPF = dr["Cpf"].ToString();
                objCliente.Endereco = dr["Endereco"].ToString();
                objCliente.CEP = Convert.ToString(dr["Cep"]);
                objCliente.Cidade = dr["Cidade"].ToString();
                objCliente.Estado = dr["Estado"].ToString();
                objCliente.Telefone = dr["Telefone"].ToString();
                objCliente.Celular = dr["Celular"].ToString();
                objCliente.Email = dr["Email"].ToString();
                objCliente.Status = dr["Status"].ToString();

                objCliente.ListLocacao = ListarLocacoes(codigo);

            }

            conn.Close();
            
            return objCliente;
        }

        public Cliente BuscarClienteCPF(string cpf)
        {
    
            Cliente objCliente = null;


            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Clientes WHERE Cpf = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", cpf);

            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows && dr.Read())
            {
                objCliente = new Cliente();
                objCliente.Codigo = Convert.ToInt32(dr["Id_Cliente"]);
                objCliente.Nome = dr["Nome"].ToString();
                objCliente.DtNascimento = Convert.ToDateTime(dr["Dt_Nascimaneto"]);
                objCliente.Sexo = dr["Sexo"].ToString();
                objCliente.EstadoCivil = dr["Estado_Civil"].ToString();
                objCliente.RG = dr["Rg"].ToString();
                objCliente.CPF = dr["Cpf"].ToString();
                objCliente.Endereco = dr["Endereco"].ToString();
                objCliente.CEP = Convert.ToString(dr["Cep"]);
                objCliente.Cidade = dr["Cidade"].ToString();
                objCliente.Estado = dr["Estado"].ToString();
                objCliente.Telefone = dr["Telefone"].ToString();
                objCliente.Celular = dr["Celular"].ToString();
                objCliente.Email = dr["Email"].ToString();
                objCliente.Status = dr["Status"].ToString();

            }

            conn.Close();

            return objCliente;
        }

        public List<LocacaoCliente> ListarLocacoes(int codigo)
        {

            List<LocacaoCliente> listaLocacao = new List<LocacaoCliente>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT Clientes.Nome, Locacoes.Dt_Atual, Locacoes.Vl_Pago, Locacoes.Dt_Devolucao,Locacoes.Dt_Prevista FROM Locacoes" +
                " INNER JOIN Clientes ON Clientes.Id_Cliente = Locacoes.Id_Cliente WHERE Locacoes.Id_Cliente = @cod";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@cod", codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                LocacaoCliente objLocacao;

                while (dr.Read())
                {

                    objLocacao = new LocacaoCliente();

                    if(dr["Dt_Devolucao"] != DBNull.Value)
                    {
                        objLocacao.NomeCli = dr["Nome"].ToString();
                        objLocacao.Dt_Atual = Convert.ToDateTime(dr["Dt_Atual"]);
                        objLocacao.Vl_Pago = Convert.ToDecimal(dr["Vl_Pago"]);
                        objLocacao.Dt_Devolucao = Convert.ToDateTime(dr["Dt_Devolucao"]);
                        objLocacao.Dt_Prevista = Convert.ToDateTime(dr["Dt_Prevista"]);
                    }
                    else
                    {
                        objLocacao.NomeCli = dr["Nome"].ToString();
                        objLocacao.Dt_Atual = Convert.ToDateTime(dr["Dt_Atual"]);
                        objLocacao.Vl_Pago = Convert.ToDecimal(dr["Vl_Pago"]);
                        //objLocacao.Dt_Devolucao = Convert.ToDateTime(dr["Dt_Devolucao"]);
                        objLocacao.Dt_Prevista = Convert.ToDateTime(dr["Dt_Prevista"]);
                    }
                    

                    listaLocacao.Add(objLocacao);

                }
            }

            conn.Close();

            return listaLocacao;
        }

        public List<CliBusca> ListarClientes()
        {
            List<CliBusca> ListaClientes = new List<CliBusca>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Clientes";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                CliBusca objCliBusca;

                while(dr.Read())
                {
                    objCliBusca = new CliBusca();
                    objCliBusca.Codigo = Convert.ToInt32(dr["Id_Cliente"]);
                    objCliBusca.Nome = dr["Nome"].ToString();
                    objCliBusca.CPF = dr["Cpf"].ToString();
                    objCliBusca.Status = dr["Status"].ToString();

                    ListaClientes.Add(objCliBusca);
                }
            }

            conn.Close();

            return ListaClientes;
        }
    }
}
