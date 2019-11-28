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

namespace GUI
{
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
            ListarClientes();

        }

        public void ListarClientes()
        {
            ClienteDAL cDal = new ClienteDAL();
            gvCliente.DataSource = cDal.ListarClientes();
        }

        private void btn_InserirCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.Nome = txt_nomeCliente.Text;
            objCliente.DtNascimento = Convert.ToDateTime(txt_DtNascimentoCliente.Text);
            objCliente.Sexo = txt_sexoCliente.Text;
            objCliente.EstadoCivil = txt_EstadoCivil.Text;
            objCliente.RG = txt_RgCliente.Text;
            objCliente.CPF = txt_CpfCliente.Text;
            objCliente.Endereco =txt_EnderecoCliente.Text;
            objCliente.CEP = txt_CepCliente.Text;
            objCliente.Cidade = txt_CidadeCliente.Text;
            objCliente.Estado = txt_Estado.Text;
            objCliente.Telefone = txt_telefoneCliente.Text;
            objCliente.Celular = txt_CelularCliente.Text;
            objCliente.Email = txt_emailCliente.Text;
            objCliente.Status = txt_statusCliente.Text;

            ClienteDAL fDal = new ClienteDAL();

            fDal.InserirCliente(objCliente);
            MessageBox.Show("Cliente Cadastrado!!");
            ListarClientes();
        }

        private void btn_excluirCliente_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_CodigoCliente.Text);

            ClienteDAL fDal = new ClienteDAL();
            fDal.ExcluirCliente(codigo);

            MessageBox.Show("Cliente excluido com sucesso!!");
            ListarClientes();
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_CodigoCliente.Text);

            ClienteDAL pDAL = new ClienteDAL();

            Cliente objCliente = pDAL.BuscarCliente(codigo);

            //Verificar se o produto não está nulo (existe no banco)
            if (objCliente != null)
            {
                txt_CodigoCliente.Text = Convert.ToString(objCliente.Codigo);
                txt_nomeCliente.Text = objCliente.Nome;
                txt_DtNascimentoCliente.Text = objCliente.DtNascimento.ToString("d");
                txt_sexoCliente.Text = objCliente.Sexo;
                txt_EstadoCivil.Text = objCliente.EstadoCivil;
                txt_RgCliente.Text = objCliente.RG;
                txt_CpfCliente.Text = objCliente.CPF;
                txt_EnderecoCliente.Text = objCliente.Endereco;
                txt_CepCliente.Text = objCliente.CEP;
                txt_CidadeCliente.Text = objCliente.Cidade;
                txt_Estado.Text = objCliente.Estado;
                txt_telefoneCliente.Text = objCliente.Telefone;
                txt_CelularCliente.Text = objCliente.Celular;
                txt_emailCliente.Text = objCliente.Email;
                txt_statusCliente.Text = objCliente.Status;

                dgvLocacoes.DataSource = objCliente.ListLocacao;
            }
            else
            {
                MessageBox.Show("Cliente não foi encontrado!");

            }
        }

        private void btn_BuscarPorCpf_Click(object sender, EventArgs e)
        {
            string codigo = txt_CpfCliente.Text;

            ClienteDAL pDAL = new ClienteDAL();

            Cliente objCliente = pDAL.BuscarClienteCPF(codigo);

            //Verificar se o produto não está nulo (existe no banco)
            if (objCliente != null)
            {
                txt_CodigoCliente.Text = Convert.ToString(objCliente.Codigo);
                txt_nomeCliente.Text = objCliente.Nome;
                txt_DtNascimentoCliente.Text = objCliente.DtNascimento.ToString("d");
                txt_sexoCliente.Text = objCliente.Sexo;
                txt_EstadoCivil.Text = objCliente.EstadoCivil;
                txt_RgCliente.Text = objCliente.RG;
                txt_CpfCliente.Text = objCliente.CPF;
                txt_EnderecoCliente.Text = objCliente.Endereco;
                txt_CepCliente.Text = objCliente.CEP;
                txt_CidadeCliente.Text = objCliente.Cidade;
                txt_Estado.Text = objCliente.Estado;
                txt_telefoneCliente.Text = objCliente.Telefone;
                txt_CelularCliente.Text = objCliente.Celular;
                txt_emailCliente.Text = objCliente.Email;
                txt_statusCliente.Text = objCliente.Status;
            }
            else
            {
                MessageBox.Show("Cliente não foi encontrado!");

            }
        }

        private void btn_AtualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.Codigo = Convert.ToInt32(txt_CodigoCliente.Text);
            objCliente.Nome = txt_nomeCliente.Text;
            objCliente.DtNascimento = Convert.ToDateTime(txt_DtNascimentoCliente.Text);
            objCliente.Sexo = txt_sexoCliente.Text;
            objCliente.EstadoCivil = txt_EstadoCivil.Text;
            objCliente.RG = txt_RgCliente.Text;
            objCliente.CPF = txt_CpfCliente.Text;
            objCliente.Endereco = txt_EnderecoCliente.Text;
            objCliente.CEP = txt_CepCliente.Text;
            objCliente.Cidade = txt_CidadeCliente.Text;
            objCliente.Estado = txt_Estado.Text;
            objCliente.Telefone = txt_telefoneCliente.Text;
            objCliente.Celular = txt_CelularCliente.Text;
            objCliente.Email = txt_emailCliente.Text;
            objCliente.Status = txt_statusCliente.Text;

            ClienteDAL pDAL = new ClienteDAL();
            pDAL.AtualizarCliente(objCliente);

            MessageBox.Show("Cliente atualizado com sucesso!");

            ListarClientes();
        }

        private void txt_estadoCivilCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
