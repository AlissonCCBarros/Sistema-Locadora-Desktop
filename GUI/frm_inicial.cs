using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_inicial : Form
    {
        public frm_inicial()
        {
            InitializeComponent();

            
           
            
        }

        private void FecharFormulariosFilhos()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }

            
        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ep_Funcionarios_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            

            frm_genero tela = new frm_genero();
            tela.MdiParent = this;
            tela.Show();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frm_Cliente tela = new frm_Cliente();
            tela.MdiParent = this;
            tela.Show();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frm_artista tela = new frm_artista();
            tela.MdiParent = this;
            tela.Show();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frm_Funcionario tela = new frm_Funcionario();
            tela.MdiParent = this;
            tela.Show();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frm_Filme tela = new frm_Filme();
            tela.MdiParent = this;
            tela.Show();
            
        }

        private void GunaImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_artista_Click(object sender, EventArgs e)
        {
            FecharFormulariosFilhos();
            frm_Locacao tela = new frm_Locacao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void gunaPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_devolucao_Click(object sender, EventArgs e)
        {
            frm_devolucao tela = new frm_devolucao();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
