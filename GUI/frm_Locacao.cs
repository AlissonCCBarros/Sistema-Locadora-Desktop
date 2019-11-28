using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frm_Locacao : Form
    {
        decimal Valor = 0;
        decimal Debito = 0;
        public frm_Locacao()
        {
            InitializeComponent();
            CarregarFilmes();
            dtprev.Value = System.DateTime.Now.AddDays(+5);
            txt_vlPago.Text = "0";
            txtDeb.Text = "0";
        }

        private void txt_DataPrevista_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_BuscarLocacao_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtIdLocacao.Text);

            LocacaoDAL lDAL = new LocacaoDAL();

            Locacao objLocacao = lDAL.Buscar(codigo);


            if (objLocacao != null)
            {
                txt_codigoFuncionarioLocacao.Text = objLocacao.Id_Funcionario.ToString();
                txt_IdClienteLocacao.Text = objLocacao.Id_Cliente.ToString();
                txtNome.Text = objLocacao.NomeCli.ToString();
                txtCPF.Text = objLocacao.CPF.ToString();
                txt_vlPago.Text = objLocacao.Vl_Pago.ToString();
                txtVlTotal.Text = objLocacao.Vl_Total.ToString();
                txtDeb.Text = objLocacao.Vl_Debito.ToString();
                cboxSituacaopag.Text = objLocacao.Tipo_Pagamento.ToString();
                dtprev.Value = objLocacao.Dt_Prevista;
                dateatual.Value = objLocacao.Dt_Atual;

            }
            else
            {
                MessageBox.Show("Locação não foi encontrada!");

            }
        }

        private void btn_InserirLocacao_Click(object sender, EventArgs e)
        {
            Locacao objLocacao = new Locacao();
            objLocacao.Id_Funcionario = Convert.ToInt32(txt_codigoFuncionarioLocacao.Text);
            objLocacao.Id_Cliente = Convert.ToInt32(txt_IdClienteLocacao.Text);
            objLocacao.Dt_Atual = Convert.ToDateTime(dateatual.Value);
            objLocacao.Dt_Prevista = Convert.ToDateTime(dtprev.Value);


            LocacaoDAL lDal = new LocacaoDAL();
            lDal.InserirLocacao(objLocacao);
            MessageBox.Show("Cadastrado com sucesso!!");

            Locacao l = lDal.BuscarLocacao();
            txtIdLocacao.Text = l.Id_Locacao.ToString();
        }

        private void btn_excluirLocacao_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtIdLocacao.Text);

            LocacaoDAL lDAL = new LocacaoDAL();

            lDAL.ExcluirLocacao(codigo);
        }

        private void btn_AtualizarLocacao_Click(object sender, EventArgs e)
        {
            Locacao objLocacao = new Locacao();

            objLocacao.Id_Funcionario = Convert.ToInt32(txt_codigoFuncionarioLocacao.Text);
            objLocacao.Id_Cliente = Convert.ToInt32(txt_IdClienteLocacao.Text);
            objLocacao.Dt_Atual = Convert.ToDateTime(dateatual.Value);
            objLocacao.Dt_Prevista = Convert.ToDateTime(dtprev.Value);
            objLocacao.Vl_Pago = Convert.ToDecimal(txt_vlPago.Text);
            objLocacao.Vl_Total = Convert.ToDecimal(txtVlTotal.Text);
            objLocacao.Vl_Debito = Convert.ToDecimal(txtDeb.Text);
            objLocacao.Tipo_Pagamento = Convert.ToString(cboxSituacaopag.Text);

           


            LocacaoDAL lDAL = new LocacaoDAL();
            lDAL.AtualizarLocacao(objLocacao);

            MessageBox.Show("Locação atualizada com sucesso!");
        }

        private void btnCpf_Click(object sender, EventArgs e)
        {
            string codigo = txtCPF.Text;

            ClienteDAL cDAL = new ClienteDAL();

            Cliente objCliente = cDAL.BuscarClienteCPF(codigo);

            
            if (objCliente != null)
            {
                txt_IdClienteLocacao.Text = Convert.ToString(objCliente.Codigo);
                txtNome.Text = objCliente.Nome;

            }
            else
            {
                MessageBox.Show("Cliente não foi encontrado!");

            }
        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void carregaCombo()
        //{
        //    string connectionString = "Data Source=localhost;Initial Catalog=VideoMania;User ID=sa;Password=a1banes";

        //    DataTable dtTabelas = new DataTable();


        //    SqlConnection conn = new SqlConnection(connectionString);

        //    conn.Open();

        //    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Filmes ORDER BY Titulo ASC", conn);

        //    //preenche o DataTable
        //    da.Fill(dtTabelas);

        //    conn.Close();

        //    //carrega as informacoes no combo
        //    cboxFilme.DataSource = dtTabelas;
        //    cboxFilme.DisplayMember = "Titulo";
        //    cboxFilme.ValueMember = "Id_Filme";
        //    txtCodBarras.Text = "CodigoDeBarras";

        //}

        private void cboxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboxFilme.SelectedValue != null)
            {
                string cod = cboxFilme.SelectedValue.ToString();
                int id = Convert.ToInt32(cod);

                FilmeDAL fDAL = new FilmeDAL();

                Filme objFilme = fDAL.PesquisarFilmes(id);

                txtCodBarras.Text = objFilme.CodigoDeBarras.ToString();
                                
                txt_vlLocacao.Text = objFilme.Preco.ToString();
            }

        }

        private void PreencherDados(Filme objFilme)
        {
            
        }

        private void CarregarFilmes()
        {
            FilmeDAL fDAL = new FilmeDAL();

            cboxFilme.DataSource = fDAL.ListarFilmes();
            cboxFilme.ValueMember = "Codigo";
            cboxFilme.DisplayMember = "Titulo";            
        }

        private void dtprev_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Ep_Locacao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddFilme_Click(object sender, EventArgs e)
        {
            Locacao objLocacao = new Locacao();
            objLocacao.Id_Locacao = Convert.ToInt32(txtIdLocacao.Text);
            objLocacao.Id_Filme = Convert.ToInt32(cboxFilme.SelectedValue);

            Valor += Convert.ToDecimal(txt_vlLocacao.Text);

            txtVlTotal.Text = Valor.ToString();

            LocacaoDAL lDal = new LocacaoDAL();
            lDal.InserirDetalhes(objLocacao);
        }

        private void btnFecharP_Click(object sender, EventArgs e)
        {
            Locacao objLocacao = new Locacao();
            objLocacao.Id_Locacao = Convert.ToInt32(txtIdLocacao.Text);
            objLocacao.Vl_Total = Valor;
            objLocacao.Vl_Pago = Convert.ToDecimal(txt_vlPago.Text);
            objLocacao.Tipo_Pagamento = cboxSituacaopag.Text;
            objLocacao.Vl_Debito = Convert.ToDecimal(txtDeb.Text);

            calc();

            LocacaoDAL lDal = new LocacaoDAL();
            lDal.FecharLocacao(objLocacao);


            MessageBox.Show("Locação Realizada!");
        }
        
        private void calc()
        {
            if (txtDeb.Text == "0")
            {
                txtDeb.Text = Convert.ToString(txtVlTotal.Text);
            }
            else
            {
                Debito = Valor - Convert.ToDecimal(txt_vlPago.Text);
            }
            
        }
        private void txt_vlPago_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
