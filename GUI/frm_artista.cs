using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DAL;
using Models;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frm_artista : Form
    {
        public frm_artista()
        {
            InitializeComponent();
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private void btn_ProcurarImagemArtista_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Selecionar Fotos";
            openFileDialog1.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    txt_diretorio_img.Text += arquivo;
                }
            }
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            Image imagem = Image.FromFile(txt_diretorio_img.Text);
            var ms = new MemoryStream();
            imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            var bytes = ms.ToArray();

            var ImageMemoryStream = new MemoryStream(bytes);

            Image imgFromStream = Image.FromStream(ImageMemoryStream);


            Artista objArtista = new Artista();
            objArtista.Nome = txt_NomeArtista.Text;
            objArtista.DtNascimento = Convert.ToDateTime(txt_dtNascimento.Text);
            objArtista.PaisNascimento = txt_PaisArtista.Text;
            objArtista.Img_Artista = bytes;


            ArtistaDAL fDal = new ArtistaDAL();
            fDal.InserirArtista(objArtista);
            MessageBox.Show("Cadastrado com sucesso!!");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_idArtista.Text);

            ArtistaDAL pDAL = new ArtistaDAL();

            pDAL.ExcluirArtista(codigo);

            MessageBox.Show("Excluido!");
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Image imagem = Image.FromFile(txt_diretorio_img.Text);
            var ms = new MemoryStream();
            imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            var bytes = ms.ToArray();

            var ImageMemoryStream = new MemoryStream(bytes);

            Image imgFromStream = Image.FromStream(ImageMemoryStream);

            Artista objArtista = new Artista();

            objArtista.Codigo = Convert.ToInt32(txt_idArtista.Text);
            objArtista.Nome = txt_NomeArtista.Text;
            objArtista.DtNascimento = Convert.ToDateTime(txt_dtNascimento.Text);
            objArtista.PaisNascimento = txt_PaisArtista.Text;
            objArtista.Img_Artista = bytes;


            ArtistaDAL pDAL = new ArtistaDAL();
            pDAL.AtualizarArtista(objArtista);

            MessageBox.Show("Artista atualizado com sucesso!");
        }

        private void btn_BuscarArtista_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_idArtista.Text);

            ArtistaDAL pDAL = new ArtistaDAL();

            Artista objArtista = pDAL.BuscarArtista(codigo);

            //Verificar se o produto não está nulo (existe no banco)
            if (objArtista != null)
            {
                txt_NomeArtista.Text = Convert.ToString(objArtista.Nome);
                txt_dtNascimento.Text = objArtista.DtNascimento.ToString("d");
                txt_PaisArtista.Text = objArtista.PaisNascimento;
                txt_diretorio_img.Text = Convert.ToString(objArtista.Img_Artista);

                dgvArtistas.DataSource = objArtista.ListFilme;

            }
            else
            {
                MessageBox.Show("Artista não foi encontrado!");

            }
        }

        private void btnpesquisanome_Click(object sender, EventArgs e)
        {
            string codigo = txt_NomeArtista.Text;

            ArtistaDAL pDAL = new ArtistaDAL();

            Artista objArtista = pDAL.BuscarArtistaNome(codigo);

            //Verificar se o produto não está nulo (existe no banco)
            if (objArtista != null)
            {
                txt_idArtista.Text = Convert.ToString(objArtista.Codigo);
                txt_NomeArtista.Text = Convert.ToString(objArtista.Nome);
                txt_dtNascimento.Text = objArtista.DtNascimento.ToString("d");
                txt_PaisArtista.Text = objArtista.PaisNascimento;
                txt_diretorio_img.Text = Convert.ToString(objArtista.Img_Artista);

                dgvArtistas.DataSource = objArtista.ListFilme;

            }
            else
            {
                MessageBox.Show("Artista não foi encontrado!");

            }
        }
    }
}
