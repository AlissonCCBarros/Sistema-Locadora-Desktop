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
    public partial class frm_genero : Form
    {
        public frm_genero()
        {
            InitializeComponent();
            ListarGeneros();
        }

        private void btn_BuscarArtista_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_idGenero.Text);

            GeneroDAL gDAL = new GeneroDAL();

            Genero objGenero = gDAL.BuscarGenero(codigo);

            //Verificar se o produto não está nulo (existe no banco)
            if (objGenero != null)
            {
                txt_Genero.Text = Convert.ToString(objGenero.Nome);
            }
            else
            {
                MessageBox.Show("Gênero não foi encontrado!");

            }
        }

        private void btn_BuscarGenero_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.Nome = txt_Genero.Text;

            GeneroDAL gDal = new GeneroDAL();
            gDal.InseriGenero(objGenero);
            MessageBox.Show("Cadastrado com sucesso!!");
        }

        private void btn_ExcluirGenero_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_idGenero.Text);

            GeneroDAL gDAL = new GeneroDAL();

            gDAL.ExcluirGenero(codigo);

            MessageBox.Show("Excluido!");
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();

            objGenero.Nome = txt_Genero.Text;


            GeneroDAL gDAL = new GeneroDAL();
            gDAL.AtualizarGenero(objGenero);

            MessageBox.Show("Gênero atualizado com sucesso!");
        }

        public void ListarGeneros()
        {
            GeneroDAL gDal = new GeneroDAL();
            dgvGen.DataSource = gDal.ListarGeneros();
        }

        private void Ep_Filme_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
