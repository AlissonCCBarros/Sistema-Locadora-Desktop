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
    public partial class frm_Funcionario : Form
    {
        public frm_Funcionario()
        {
            InitializeComponent();
           CarregarFunc();
        }

        private void CarregarFunc()
        {
            FuncionarioDAL fDal = new FuncionarioDAL();
            gvFunc.DataSource = fDal.ListarFuncionarios();
        }

        private void btn_InserirFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();
            objFuncionario.Nome = txt_NomeFuncionario.Text;
            objFuncionario.DtNascimento = Convert.ToDateTime(txt_dataNascimento.Text);
            objFuncionario.Sexo = cb_sexoFuncionario.Text;
            objFuncionario.EstadoCivil = txt_estadocivil.Text;
            objFuncionario.RG = txt_RgFuncionario.Text;
            objFuncionario.CPF = txt_CpfFuncionario.Text;
            objFuncionario.Endereco = txt_EnderecoFuncionario.Text;
            objFuncionario.CEP = txt_CepFuncionario.Text;
            objFuncionario.Cidade =txt_CidadeFuncionario.Text;
            objFuncionario.Estado = txt_Estado.Text;
            objFuncionario.Telefone = txt_TelefoneFuncionario.Text;
            objFuncionario.Celular = txt_CelularFuncionario.Text ;
            objFuncionario.Email = txt_emailFuncionario.Text;
            objFuncionario.Status = txt_status.Text;

            FuncionarioDAL fDal = new FuncionarioDAL();

            fDal.InserirFuncionario(objFuncionario);
            MessageBox.Show("Funcionario Cadastrado!!");
            CarregarFunc();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_CodigoFuncionario.Text);

            FuncionarioDAL fDal = new FuncionarioDAL();
            fDal.ExcluirFuncionario(codigo);

            MessageBox.Show("Funcionario excluido com sucesso!!");
            CarregarFunc();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_CodigoFuncionario.Text);

            FuncionarioDAL fDAL = new FuncionarioDAL();

            Funcionario objFunc = fDAL.BuscarFuncionario(codigo);

            //Verificar se o produto não está nulo (existe no banco)
            if (objFunc != null)
            {
                txt_CodigoFuncionario.Text = Convert.ToString(objFunc.Codigo);
                txt_NomeFuncionario.Text = objFunc.Nome;
                txt_dataNascimento.Text = objFunc.DtNascimento.ToString("d");
                cb_sexoFuncionario.Text = objFunc.Sexo;
                txt_estadocivil.Text = objFunc.EstadoCivil;
                txt_RgFuncionario.Text = objFunc.RG;
                txt_CpfFuncionario.Text = objFunc.CPF;
                txt_EnderecoFuncionario.Text = objFunc.Endereco;
                txt_CepFuncionario.Text = objFunc.CEP;
                txt_CidadeFuncionario.Text = objFunc.Cidade;
                txt_Estado.Text = objFunc.Estado;
                txt_TelefoneFuncionario.Text = objFunc.Telefone;
                txt_CelularFuncionario.Text = objFunc.Celular;
                txt_CepFuncionario.Text = objFunc.Telefone;
                txt_emailFuncionario.Text = objFunc.Email;
                txt_status.Text = objFunc.Status;

                dgvLocPen.DataSource = objFunc.ListFilmes;
            }
            else
            {
                MessageBox.Show("Funcionario não foi encontrado!");
                
            }
        }

        private void btn_BuscarCPF_Click(object sender, EventArgs e)
        {
            string cpf= txt_CpfFuncionario.Text;

            FuncionarioDAL fDAL = new FuncionarioDAL();

            Funcionario objFuncionario = fDAL.BuscarFuncionarioCPF(cpf);

            //Verificar se o produto não está nulo (existe no banco)
            if (objFuncionario != null)
            {
                txt_CodigoFuncionario.Text = Convert.ToString(objFuncionario.Codigo);
                txt_NomeFuncionario.Text = objFuncionario.Nome;
                txt_dataNascimento.Text = objFuncionario.DtNascimento.ToString("d");
                cb_sexoFuncionario.Text = objFuncionario.Sexo;
                txt_estadocivil.Text = objFuncionario.EstadoCivil;
                txt_RgFuncionario.Text = objFuncionario.RG;
                txt_CpfFuncionario.Text = objFuncionario.CPF;
                txt_EnderecoFuncionario.Text = objFuncionario.Endereco;
                txt_CepFuncionario.Text = objFuncionario.CEP;
                txt_CidadeFuncionario.Text = objFuncionario.Cidade;
                txt_Estado.Text = objFuncionario.Estado;
                txt_TelefoneFuncionario.Text = objFuncionario.Telefone;
                txt_CelularFuncionario.Text = objFuncionario.Celular;                
                txt_emailFuncionario.Text = objFuncionario.Email;
                txt_status.ValueMember = objFuncionario.Status;
            }
            else
            {
                MessageBox.Show("Funcionario não foi encontrado!");

            }
        }

        private void btn_atualiarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario objFuncionario = new Funcionario();

            objFuncionario.Codigo = Convert.ToInt32(txt_CodigoFuncionario.Text);
            objFuncionario.Nome = txt_NomeFuncionario.Text;
            objFuncionario.DtNascimento = Convert.ToDateTime(txt_dataNascimento.Text);
            objFuncionario.Sexo = cb_sexoFuncionario.Text;
            objFuncionario.EstadoCivil = txt_estadocivil.Text;
            objFuncionario.RG = txt_RgFuncionario.Text;
            objFuncionario.CPF = txt_CpfFuncionario.Text;
            objFuncionario.Endereco = txt_EnderecoFuncionario.Text;
            objFuncionario.CEP = txt_CepFuncionario.Text;
            objFuncionario.Cidade = txt_CidadeFuncionario.Text;
            objFuncionario.Estado = txt_Estado.Text;
            objFuncionario.Telefone = txt_TelefoneFuncionario.Text;
            objFuncionario.Celular = txt_CelularFuncionario.Text;
            objFuncionario.Email = txt_emailFuncionario.Text;
            objFuncionario.Status = txt_status.Text;

            FuncionarioDAL pDAL = new FuncionarioDAL();
            pDAL.AtualizarFuncionario(objFuncionario);

            MessageBox.Show("Funcionario atualizado com sucesso!");

            CarregarFunc();
        }

        private void Ep_Funcionarios_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
