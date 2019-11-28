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
    public partial class frm_devolucao : Form
    {
        public frm_devolucao()
        {
            InitializeComponent();

            txt_vlMultaDevolucao.Text = "0";
        }

        private void btnBuscarLoc_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_locacao.Text);
            int dias = 0;
            int itens = 0;

            DevolucaoDAL dDAL = new DevolucaoDAL();

            Locacao objLocacao = dDAL.BuscarLocacao(codigo);
            

            if (objLocacao != null)
            {
                dgvfilmelOCACAO.DataSource = objLocacao.ListLocacao;
                cboxSituacaopag.Text = objLocacao.Tipo_Pagamento.ToString();
                if(objLocacao.Vl_Debito > 0)
                {
                    txt_vlTotalDevolucao.Text = objLocacao.Vl_Debito.ToString();
                }else
                {
                    txt_vlTotalDevolucao.Text = objLocacao.Vl_Total.ToString();
                }                            
                
                
            }

            Locacao objL = dDAL.BuscarQntdFilmes(codigo);
            if(objL != null)
            {
               itens = Convert.ToInt32(objL.Itens);
            }

            Locacao objLoc = dDAL.BuscarDias(codigo);
            if(objLoc != null)
            {
                dias = Convert.ToInt32(objLoc.DiasAtraso);
            }

            if(dias > 0)
            {
                decimal multa = (dias * 1) * itens;
                txt_vlMultaDevolucao.Text = multa.ToString();
                decimal nTotal = Convert.ToDecimal(txt_vlTotalDevolucao.Text) + multa;
                txt_vlTotalDevolucao.Text = nTotal.ToString();
            }

        }

        private void btn_Buscar_Item_Click(object sender, EventArgs e)
        {
            string codigo = txt_CodBarrasDevolucao.Text;

            DevolucaoDAL dDAL = new DevolucaoDAL();

            Locacao objDevolucao= dDAL.BuscarFilmeCodBarras(codigo);

            if (objDevolucao != null)
            {
                txtIdFilme.Text = Convert.ToString(objDevolucao.Id_Filme);

            }
            else
            {
                MessageBox.Show("Filme não foi encontrado!");

            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtIdFilme.Text);

            DevolucaoDAL dDAL = new DevolucaoDAL();

            dDAL.DevolverFilme(codigo);

            MessageBox.Show("Filme Devolvido!");
        }

        private void btn_RegistrarDevolucao_Click(object sender, EventArgs e)
        {
            Locacao objLocacao = new Locacao();
            objLocacao.Id_Locacao = Convert.ToInt32(txt_locacao.Text);
            objLocacao.Vl_Total = Convert.ToDecimal(txt_vlTotalDevolucao.Text);
            objLocacao.Vl_Pago = Convert.ToDecimal(txt_VlPagoDevolucao.Text);
            objLocacao.Tipo_Pagamento = cboxSituacaopag.Text;
            objLocacao.Vl_Multa = Convert.ToDecimal(txt_vlMultaDevolucao.Text);
            objLocacao.Dt_Devolucao = Convert.ToDateTime(dtDevolu.Value);

            DevolucaoDAL lDal = new DevolucaoDAL();
            lDal.InserirDevolucao(objLocacao);


            MessageBox.Show("Devolução Realizada!");
        }

        private void btn_BuscarDevolucaoID_Click(object sender, EventArgs e)
        {

        }
    }
}
